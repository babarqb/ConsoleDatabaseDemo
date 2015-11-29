using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDatabaseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new NorthwindContext())
            {
                foreach (var customer in ctx.Customers.ToList().FindAll(c => c.Country == "UK"))
                {
                    Console.WriteLine(customer.ContactName);
                }
            }
        }
    }
}
