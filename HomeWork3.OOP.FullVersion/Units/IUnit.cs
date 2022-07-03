using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.OOP.FullVersion.Units
{
    public interface IUnit
    {
        void Attack(Unit unit);

        void TakingDamage();

        void TakingHealing();

        void UsingSpecialAbility();

        void EndingSpecialAbility();
    }
}
