using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.OOP.FullVersion.Units
{
    public class DragonhawkRider : Unit
    {
        public override string Name => "DragonhawkRider";

        public override int Cost => 200;

        public override string DamageType => "Physical";

        public DragonhawkRider()
        {
            Health = 575;
            Damage = 19;
            Armor = 1;
        }

        public override void TakingHealing()
        {
            if (Health > 575)
            {
                Health = 575;
            }
        }

        public override void UsingSpecialAbility()
        {
            Damage += 9;
        }

        public override void EndingSpecialAbility()
        {
            Damage -= 9;
        }
    }
}
