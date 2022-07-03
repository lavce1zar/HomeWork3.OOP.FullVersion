using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.OOP.FullVersion.Units
{
    public class SpellBreaker : Unit
    {
        public override string Name => "SpellBreaker";

        public override int Cost => 215;

        public override string DamageType => "Physical";

        public SpellBreaker()
        {
            Health = 600;
            Damage = 14;
            Armor = 3;
        }

        public override void TakingHealing()
        {
            if (Health > 600)
            {
                Health = 600;
            }
        }

        public override void UsingSpecialAbility()
        {
            Damage += 6;
        }

        public override void EndingSpecialAbility()
        {
            Damage -= 6;
        }
    }
}
