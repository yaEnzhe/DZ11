using System;
using Tumakov14.Classes;
using static Tumakov14.Enums.BankAcc;

namespace Tumakov14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14.1
            Console.WriteLine("#14.1");
            var bankAcc1 = new BankAccount("Ivan", "Ivanov", "Ivanovich", 100, CurrentAcc);
            var bankAcc2 = new BankAccount("Petr", "Petrov", 1000, CurrentAcc);
            bankAcc1.DumpToScreen();
            bankAcc2.DumpToScreen();

            //14.2
            Console.WriteLine("\n#14.2");
            RationalNum r1 = new RationalNum(1, 2);
            RationalNum r2 = new RationalNum(3, 4);
            var developerAttributes = typeof(RationalNum).GetCustomAttributes(typeof(DeveloperInfoAttribute), false);
            foreach (DeveloperInfoAttribute attribute in developerAttributes)
            {
                Console.WriteLine($"Разработчик: {attribute.DeveloperName}, Дата: {attribute.DevelopmentDate}");
            }

            //14.1 dz
            Console.WriteLine("\n#14.1 dz");
            var developerAndOrganizationAttributes = typeof(BankAccount).GetCustomAttributes(typeof(InfoAttribute), false);
            foreach (InfoAttribute attribute in developerAndOrganizationAttributes)
            {
                Console.WriteLine($"Разработчик: {attribute.DeveloperName}, Организация: {attribute.OrganizationName}");
            }


        }
    }
}
