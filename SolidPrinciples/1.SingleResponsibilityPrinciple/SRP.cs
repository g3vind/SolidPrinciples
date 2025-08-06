using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples._1.SingleResponsibilityPrinciple
{
    public class SRP
    {
        /*public void CalculateTotal()
        {

        }

        public void SaveToDb()
        {

        }

        public void SendEmail()
        {
        }*/

        // above is not following single responsibility principle
        public class Invoice
        {
            public void CalculateTotal()
            {

            }
        }

        public class InvoiceDb
        {
            public void SaveToDb()
            {
            }
        }
        public class InvoiceEmail
        {
            public void SendEmail()
            {
            }
        }

        // now it is following single responsibility principle
    }
}
