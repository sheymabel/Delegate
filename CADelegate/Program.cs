
using CADelegate;

class program
{
    static void main(String[] args)
    {
        var emps = new Employee[] {

            new Employee { Id = 1, Name = "sheyma", Gender = "F", Totalesales = 32356 },
            new Employee { Id = 2, Name = "storm", Gender = "H", Totalesales =52356 },
             new Employee { Id = 3, Name = "mahdi", Gender = "H", Totalesales = 62356 },
              new Employee { Id = 4, Name = "fathiz", Gender = "F", Totalesales = 50356 },
            new Employee { Id = 5, Name = "fathiza", Gender = "H", Totalesales = 30356 },
            new Employee { Id = 6, Name = "dizh", Gender = "H", Totalesales = 60356 },
            new Employee { Id = 7, Name = "szejhbheyma", Gender = "F", Totalesales =7056 },

        };
        var report = new Report();
        report.proecessEmployessWthith60000PlusSales(emps);
        report.proecessEmployessWthithSales30000(emps);
        report.proecessEmployessWthithSalesBetween30000and599999(emps);

        Console.ReadKey();

    }
}
