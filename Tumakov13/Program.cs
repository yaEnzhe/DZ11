using System;
using Tumakov13.Classes;
using static Tumakov13.Classes.Buildings;
using static Tumakov13.Classes.BankAccount;
using static Tumakov13.Enums.BankAcc;

namespace Tumakov13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13.1
            Console.WriteLine("#13.1");
            var bankAcc1 = new BankAccount("Ivan", "Ivanov", "Ivanovich", 100, CurrentAcc);
            var bankAcc2 = new BankAccount("Petr", "Petrov", 1000, CurrentAcc);
            bankAcc1.PrintInfo();
            bankAcc2.PrintInfo();

            //13.2
            Console.WriteLine("\n#13.2");
            AddMoney(100, ref bankAcc1);
            Console.WriteLine($"Транзакция: {bankTransactions[0].Money} {bankTransactions[0].DateTime}");


            //13.1 dz
            Console.WriteLine("\n#13.1 dz");
            var build1 = new Building(6, 3, 9, 1);
            var build2 = new Building(8, 4, 12, 1);
            var build3 = new Building(10, 5, 15, 1);
            var build4 = new Building(12, 6, 18, 1);
            var build5 = new Building(14, 7, 21, 1);
            var build6 = new Building(2, 1, 1, 1);
            var build7 = new Building(16, 8, 24, 1);
            var build8 = new Building(18, 9, 27, 1);
            var build9 = new Building(20, 10, 30, 1);
            var build10 = new Building(22, 11, 33, 1);
            var buildings = new Buildings();
            
            //13.2 dz
            Console.WriteLine("\n#13.2 dz");
            Buildings.buildings[0] = build1;
            Buildings.buildings[1] = build2;
            Buildings.buildings[2] = build3;
            Buildings.buildings[3] = build4;
            Buildings.buildings[4] = build5;
            Buildings.buildings[5] = build6;
            Buildings.buildings[6] = build7;
            Buildings.buildings[7] = build8;
            Buildings.buildings[8] = build9;
            Buildings.buildings[9] = build10;
            for (int i = 1; i <= Buildings.buildings.Length; i++)
            {
                var building = FindByBuildingNum(i);
                if (building == null)
                {
                    Console.WriteLine("Здание не существует");
                }
                building.PrintInfo();
            }

        }
    }
}
