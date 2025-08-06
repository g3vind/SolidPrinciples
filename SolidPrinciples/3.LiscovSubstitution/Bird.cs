using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples._3.LiscovSubstitution
{
    /*public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }

    public class Sparrow : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Sparrow is flying");
        }
    }

    public class Ostrich : Bird
    {
        public override void Fly()
        {
            throw new NotSupportedException("Ostriches cannot fly");
        }
    }*/

    // above is not following the liscov substitution principle

    // splitting behaviour using interfaces

    public interface IBird
    {
        void Eat();
    }
    public interface IFlyingBird : IBird
    {
        void Fly();
    }

    public class Sparrow : IFlyingBird
    {
        public void Eat()
        {
            Console.WriteLine("Sparrow is eating");
        }
        public void Fly()
        {
            Console.WriteLine("Sparrow is flying");
        }
    }

    public class Ostrich : IBird
    {
        public void Eat()
        {
            Console.WriteLine("Ostrich is eating");
        }
        // Ostrich does not implement Fly method, so it cannot fly
    }

}
