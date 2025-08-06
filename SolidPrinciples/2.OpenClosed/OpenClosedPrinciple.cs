using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples._2.OpenClosed
{
    public class OpenClosedPrinciple
    {
        /*public void Print(string Shape)
        {
            if (Shape == "Circle")
            {
                // Print Circle
            }
            else if (Shape == "Square")
            {
                // Print Square
            }
            else if (Shape == "Triangle")
            {
                // Print Triangle
            }
            else
            {
                throw new NotSupportedException("Shape not supported");
            }
        }*/

        // above is not following open closed principle
        public interface IShape
        {
            void Print();
        }

        public class Circle : IShape
        {
            public void Print()
            {
                // Print Circle
            }
        }

        public class Square : IShape
        {
            public void Print()
            {

            }
        }

        public class Triangle : IShape
        {
            public void Print()
            {
                // Print Triangle
            }
        }

        // now above is following the open closed principle
    }
}
