namespace BuilderAndFactoryMethod.Builders
{
    public sealed class FriendsPicnicBuilder : PicnicBuilder
    {
        public override void GenerateAdditional(int countAdds)
        {
            base.GenerateAdditional(countAdds);

            Result.Addition.Add("Настольная игра");
            Result.Addition.Add("Карточная игра");
        }
    }
}
