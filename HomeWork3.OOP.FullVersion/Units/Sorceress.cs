using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.OOP.FullVersion.Units
{
    public class Sorceress : Unit
    {
        public override string Name => "Sorceress";

        public override int Cost => 155;

        public override string DamageType => "Magical";

        public Sorceress()
        {
            Health = 325;
            Damage = 11;
            Armor = 0;
        }

        public override void TakingHealing()
        {
            if (Health > 325)
            {
                Health = 325;
            }
        }

        public override void UsingSpecialAbility()
        {
            Damage += 15;
        }

        public override void EndingSpecialAbility()
        {
            Damage -= 15;
        }
    }
}
