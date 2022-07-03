using HomeWork3.OOP.FullVersion.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.OOP.FullVersion.Factory
{
    internal interface IUnitFactory
    {
        IUnit CreateUnit(string name);
    }
}
