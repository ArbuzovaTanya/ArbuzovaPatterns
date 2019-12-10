namespace Strategy
{
    public sealed class Worker
    {
        public void DoWork(IJob job)
        {
            job?.DoJob();
        }
    }
}
