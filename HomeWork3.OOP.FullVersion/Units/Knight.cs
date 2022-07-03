using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.OOP.FullVersion.Units
{
    public class Knight : Unit
    {
        public override string Name => "Knight";

        public override int Cost => 245;

        public override string DamageType => "Physical";

        public Knight()
        {
            Health = 835;
            Damage = 34;
            Armor = 5;
        }

        public override void TakingHealing()
        {
            if (Health > 835)
            {
                Health = 835;
            }
        }

        public override void UsingSpecialAbility()
        {
            Health += 150;
        }

        public override void EndingSpecialAbility()
        {
            Health -= 150;
        }
    }
}
