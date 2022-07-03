using HomeWork3.OOP.FullVersion.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.OOP.FullVersion
{
    public class Army
    {
        public string? Name { get; set; }
        public List<Unit> ArmyOfUnits { get; set; }

        public Army()
        {
            ArmyOfUnits = new List<Unit>();
        }

        public static void DoBattle(Army army1, Army army2)
        {
            if (army1.ArmyOfUnits.Count == 0 || army2.ArmyOfUnits.Count == 0)
            {
                Console.WriteLine("One of the army doesn't have units.");
                Console.WriteLine();
                return;
            }

            Console.WriteLine("Battle starts now");
            
            for (int i = 0, j = 0; i != army1.ArmyOfUnits.Count - 1 || j != army2.ArmyOfUnits.Count - 1; )
            {
                army1.ArmyOfUnits[i].Attack(army2.ArmyOfUnits[0]);
                if (army2.ArmyOfUnits[0]._isDead == true)
                {
                    Console.WriteLine($"Army2 unit {army2.ArmyOfUnits[0].Name} is dead.");
                    army2.ArmyOfUnits.RemoveAt(0);
                    if (army2.ArmyOfUnits.Count == 0)
                    {
                        Console.WriteLine($"{army2.Name} is dead.");
                        Console.WriteLine();
                        break;
                    }
                    if (j > 0)
                    {
                        j--;
                    }
                }
                if (army1.ArmyOfUnits[i] is Priest priest1)
                {
                    priest1.Heal(army1.ArmyOfUnits[0]);
                }

                if (i != army1.ArmyOfUnits.Count - 1)
                {
                    i++;
                }

                army2.ArmyOfUnits[j].Attack(army1.ArmyOfUnits[0]);
                if (army1.ArmyOfUnits[0]._isDead == true)
                {
                    Console.WriteLine($"Army1 unit {army1.ArmyOfUnits[0].Name} is dead.");
                    army1.ArmyOfUnits.RemoveAt(0);
                    if (army1.ArmyOfUnits.Count == 0)
                    {
                        Console.WriteLine($"{army1.Name} is dead.");
                        Console.WriteLine();
                        break;
                    }
                    if (i > 0)
                    {
                        i--;
                    }
                }
                if (army2.ArmyOfUnits[j] is Priest priest2)
                {
                    priest2.Heal(army1.ArmyOfUnits[0]);
                }

                if (j != army2.ArmyOfUnits.Count - 1)
                {
                    j++;
                }
            }

            Console.WriteLine("Battle ends.");
            Console.WriteLine();
        }

        public long GetCostOfArmy()
        {
            var cost = 0L;

            foreach (var unit in ArmyOfUnits)
            {
                cost += (long)unit.Cost;
            }

            return cost;
        }

        public long GetDamageOfArmy()
        {
            var damage = 0L;

            foreach (var unit in ArmyOfUnits)
            {
                damage += (long)unit.Damage;
            }

            return damage;
        }

        public long GetHealthOfArmy()
        {
            var health = 0L;

            foreach (var unit in ArmyOfUnits)
            {
                health += (long)unit.Health;
            }

            return health;
        }

        public void FindAndPrintUnitsInHealthRange(int startOfRange, int endOfRange)
        {
            foreach (var unit in ArmyOfUnits)
            {
                Console.WriteLine($"Looking for units with Health in Range {startOfRange} - {endOfRange}.");

                if (unit.Health >= startOfRange && unit.Health <= endOfRange)
                {
                    Console.WriteLine(unit);
                }

                Console.WriteLine();
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} have {ArmyOfUnits.Count} units.");
            Console.WriteLine($"Cost of Army => {GetCostOfArmy()}.");
            Console.WriteLine($"Average Damage of Army => {GetDamageOfArmy()}.");
            Console.WriteLine($"Average Health of Army => {GetHealthOfArmy()}.");
            Console.WriteLine();
        }

        public void PrintUnits()
        {
            foreach (var unit in ArmyOfUnits)
            {
                Console.WriteLine(unit);
            }

            Console.WriteLine();
        }
    }
}
