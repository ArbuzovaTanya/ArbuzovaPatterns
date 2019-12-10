using BuilderAndFactoryMethod;
using BuilderAndFactoryMethod.Builders;
using BuilderAndFactoryMethod.Factories;
using ChainAndDelegate;
using Iterator;
using Observer;
using Strategy;
using Strategy.GoodDevelop;
using Strategy.Philosophical;
using Strategy.Swimmer;
using System;
using System.Text;

namespace ArbuzovaPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ChainAndDelegateExample();

            Console.ReadKey();
        }

        private static void Separate()
        {
            Console.WriteLine("-----------------------\n");
        }

        private static void StrategyExample()
        {
            Worker worker = new Worker();

            worker.DoWork(new PhilosophicalJob());
            Separate();

            worker.DoWork(new SwimmerJob());
            Separate();

            worker.DoWork(new GoodDevelopJob());
        }

        private static void IteratorExample()
        {
            Boyfriend[] phones = new Boyfriend[]
            {
                new Boyfriend{ Name = "Саша" },
                new Boyfriend{ Name = "Гоша" },
                new Boyfriend{ Name = "Серега" },
                new Boyfriend{ Name = "Володя" },
                new Boyfriend{ Name = "Женя" },
                new Boyfriend{ Name = "Коля" },
                new Boyfriend{ Name = "Вова" },
                // лень продолжать
            };

            var interator = new ExGuys(phones).GetIterator();
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Список бывших:");

            while (interator.MoveNext())
                stringBuilder.AppendLine(interator.Current.Name);

            Console.WriteLine(stringBuilder.ToString());
        }

        private static void ObserverExample()
        {
            var woman = new Woman(new WomanInfo { Name = "Маша" });
            var man = new Man { Name = "Миша"};

            woman.RegisterObserver(man);

            woman.Say("Ты такой хороший");
            woman.Say("Этой ночью я твоя");
            woman.Say("Вчера было так хорошо");
            woman.Say("Я немного беремена");

            woman.RemoveObserver(man);
            woman.Say("Козел!!!");
        }

        private static void BuilderAndFactoryMethodExample()
        {
            PicnicBuilder picnicBuilder = new LovePicnicBuilder();
            IMeatFactory meatFactory = new GoodMeatFactory();
            picnicBuilder.AddMeats(meatFactory);
            picnicBuilder.AddMeats(meatFactory);
            picnicBuilder.AddMeats(meatFactory);
            picnicBuilder.AddMeats(meatFactory);
            picnicBuilder.GenerateAdditional(4);
            Console.WriteLine(picnicBuilder.Result.ToString());

            Separate();

            picnicBuilder = new FriendsPicnicBuilder();
            meatFactory = new DoNotComplainMeatFactory();
            picnicBuilder.AddMeats(meatFactory);
            picnicBuilder.AddMeats(meatFactory);
            picnicBuilder.AddMeats(meatFactory);
            picnicBuilder.AddMeats(meatFactory);
            picnicBuilder.AddMeats(meatFactory);
            picnicBuilder.AddMeats(meatFactory);
            picnicBuilder.AddMeats(meatFactory);
            picnicBuilder.AddMeats(meatFactory);
            picnicBuilder.AddMeats(meatFactory);
            picnicBuilder.AddMeats(meatFactory);
            picnicBuilder.GenerateAdditional(30);
            Console.WriteLine(picnicBuilder.Result.ToString());
        }

        private static void ChainAndDelegateExample()
        {
            string resumeOrig = "Я Иванов Иван Иванович. Java Java Java Java Java Java v Java Java Java Java Java Java Java v Java v vJava Java";

            var recruiterCenter = new RecruiterCenter
            {
                Site = new Recruiter((resume) => !string.IsNullOrEmpty(resume)),
                ItRecruiter = new Recruiter((resume) => resume.Contains("Java")),
                TeamLead = new Recruiter((resume) => 
                {
                    bool result = resume.Split().Length < 20;

                    if (!result)
                    {
                        Console.WriteLine("Дурака ты кусок! Уложись в 20 слов или того меньше");
                    }

                    return result;
                })
            };

            recruiterCenter.Site.SetNextRecruiter(recruiterCenter.ItRecruiter);
            recruiterCenter.ItRecruiter.SetNextRecruiter(recruiterCenter.TeamLead);

            Console.WriteLine($"resume: '{resumeOrig}'");
            Console.WriteLine($"answer: '{recruiterCenter.ViewResume(resumeOrig)}'");
        }
    }
}
