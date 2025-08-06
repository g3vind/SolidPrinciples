namespace SolidPrinciples._4.InterfaceSegregationPrinciple
{
    class ISP
    {
        // create small focused interfaces instead of large general-purpose interfaces
        //public interface IWorker
        //{
        //    public void Work();
        //    public void Eat();
        //    public void Sleep();
        //}

        // above is not folloing // Interface Segregation Principle (ISP)
    }

    public interface IWorker
    {
        void Work();
    }

    public interface IEater
    {
        void Eat();
    }

    public class DihadiWorker : IWorker, IEater
    {
        public void Work()
        {
            // Implementation for work
        }
        public void Eat()
        {
            // Implementation for eat
        }
    }

    // If you ever see a method like throw new NotImplementedException() — that's a red flag that ISP is being violated.
}
