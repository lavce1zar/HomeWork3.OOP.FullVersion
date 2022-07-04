using System;
using HomeWork3.OOP.FullVersion.Factory;
using HomeWork3.OOP.FullVersion.Units;

namespace HomeWork3.OOP.FullVersion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the strategy game app!");
            Console.WriteLine();

            Console.WriteLine("Using files to create Armies");
            Console.WriteLine();

            var pathForArmy1 = @"D:\Documents\Learning\net-samples\HomeWork3.OOP.FullVersion\HomeWork3.OOP.FullVersion\Army1.txt";
            var pathForArmy2 = @"D:\Documents\Learning\net-samples\HomeWork3.OOP.FullVersion\HomeWork3.OOP.FullVersion\Army2.txt";
            
            Army army1;
            Army army2;

            try
            {
                army1 = CreateArmyFromFile(pathForArmy1);
            }
            catch(Exception)
            {
                Console.WriteLine("Incorrect input. Please, check file or path.");
                Console.WriteLine("Filling Army automatically");
                army1 = CreateArmyAutomatically();
            }
            army1.Name = "Army1";

            try
            {
                army2 = CreateArmyFromFile(pathForArmy2);
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input. Please, check file or path.");
                Console.WriteLine("Filling Army automatically");
                army2 = CreateArmyAutomatically();
            }
            army2.Name = "Army2";

            army1.PrintInfo();
            army2.PrintInfo();

            army1.ArmyOfUnits.Sort();
            Console.WriteLine($"{army1.Name} is sorted by damage");

            army1.PrintUnits();

            army2.FindAndPrintUnitsInHealthRange(400, 590);

            army1.PrintInfo();
            army2.PrintInfo();

            while (army1.ArmyOfUnits.Count != 0 && army2.ArmyOfUnits.Count != 0)
            {
                Army.DoBattle(army1, army2);
                army1.PrintInfo();
                army2.PrintInfo();
            }
        }

        public static Army CreateArmyFromFile(string path)
        {
            var values = File.ReadAllLines(path);
            var army = new Army();
            var factory = new UnitFactory();

            for (int i = 0; i < values.Length; i += 2)
            {
                var numberOfUnits = Convert.ToInt32(values[i + 1]);

                for (int j = 0; j < numberOfUnits; j++)
                {
                    army.ArmyOfUnits.Add((Unit)factory.CreateUnit(values[i]));
                }
            }

            Console.WriteLine("Army is created");
            Console.WriteLine();
            return army;
        }

        public static Army CreateArmyAutomatically()
        {
            var army = new Army();
            var factory = new UnitFactory();

            for (int j = 0; j < 10; j++)
            {
                army.ArmyOfUnits.Add((Unit)factory.CreateUnit("Footman"));
                army.ArmyOfUnits.Add((Unit)factory.CreateUnit("Rifleman"));
                army.ArmyOfUnits.Add((Unit)factory.CreateUnit("Knight"));
                army.ArmyOfUnits.Add((Unit)factory.CreateUnit("Priest"));
                army.ArmyOfUnits.Add((Unit)factory.CreateUnit("Sorceress"));
                army.ArmyOfUnits.Add((Unit)factory.CreateUnit("SpellBreaker"));
                army.ArmyOfUnits.Add((Unit)factory.CreateUnit("GryphonRider"));
                army.ArmyOfUnits.Add((Unit)factory.CreateUnit("DragonhawkRider"));
            }

            Console.WriteLine("Army is created");
            Console.WriteLine();
            return army;
        }
    }
}