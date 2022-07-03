using HomeWork3.OOP.FullVersion.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.OOP.FullVersion.Factory
{
    internal class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string name)
        {
            name = name.Trim();
            name = name.ToLowerInvariant();
            switch (name)
            {
                case "footman":
                    return new Footman();
                case "rifleman":
                    return new Rifleman();
                case "knight":
                    return new Knight();
                case "priest":
                    return new Priest();
                case "sorceress":
                    return new Sorceress();
                case "spellbreaker":
                    return new SpellBreaker();
                case "gryphonrider":
                    return new GryphonRider();
                case "dragonhawkrider":
                    return new DragonhawkRider();
                default:
                    Console.WriteLine("Incorrect Input");
                    throw new Exception();
            };
        }
    }
}
