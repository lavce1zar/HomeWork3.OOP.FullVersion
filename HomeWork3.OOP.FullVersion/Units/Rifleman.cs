using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.OOP.FullVersion.Units
{
    public class Rifleman : Unit
    {
        public override string Name => "Rifleman";

        public override int Cost => 205;

        public override string DamageType => "Physical";

        public Rifleman()
        {
            Health = 535;
            Damage = 21;
            Armor = 0;
        }

        public override void TakingHealing()
        {
            if (Health > 535)
            {
                Health = 535;
            }
        }

        public override void UsingSpecialAbility()
        {
            Damage += 10;
        }

        public override void EndingSpecialAbility()
        {
            Damage -= 10;
        }
    }
}
