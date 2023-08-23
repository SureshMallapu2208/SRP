using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class Customer : ICustomer
    {
        public void AddCustomer()
        {
            try
            {
                // TODO: Insert Logic Need to Written
                Console.WriteLine("Customer Added.");
            }
            catch (Exception ex)
            {

                ErrorLog.WriteLog(new string[] { ex.Message.ToString() });
            }

        }

        public void RemoveCustomer()
        {
            // TODO: Remove Logic Need to Written
            Console.WriteLine("Customer Removed.");
        }

        public void UpdateCustomer()
        {
            // TODO: Update Logic Need to Written
            Console.WriteLine("Customer Removed.");
        }
    }
}
