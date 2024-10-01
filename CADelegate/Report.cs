using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADelegate
{
    internal class Report
    {
        public void proecessEmployessWthith60000PlusSales(Employee[] employees) {
            Console.WriteLine("Employees with $60,00+sales");
            Console.WriteLine("------------------------------------------");
            foreach (var e in employees)
            { 
                if(e.Totalesales >= 60000m)
                  {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | {e.Totalesales}");
                  }
            }
            Console.WriteLine("\n\n");
        }
        public void proecessEmployessWthithSalesBetween30000and599999(Employee[] employees)
        {
            Console.WriteLine("Employees with $30000 and $599999 ");
            Console.WriteLine("------------------------------------------");
            foreach (var e in employees)
            {
                if (e.Totalesales >= 60000m && e.Totalesales >= 30000m)
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | {e.Totalesales}");
                }
            }
            Console.WriteLine("\n\n");
        }
        public void proecessEmployessWthithSales30000(Employee[] employees)
        {
            Console.WriteLine("Employees with $30000 and $599999 ");
            Console.WriteLine("------------------------------------------");
            foreach (var e in employees)
            {
                if (e.Totalesales < 30000m)
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | {e.Totalesales}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
