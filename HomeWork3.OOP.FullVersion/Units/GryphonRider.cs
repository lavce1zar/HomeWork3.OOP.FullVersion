using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.OOP.FullVersion.Units
{
    internal class GryphonRider : Unit
    {
        public override string Name => "GryphonRider";

        public override int Cost => 280;

        public override string DamageType => "Magical";

        public GryphonRider()
        {
            Health = 825;
            Damage = 50;
            Armor = 0;
        }

        public override void TakingHealing()
        {
            if (Health > 825)
            {
                Health = 825;
            }
        }

        public override void UsingSpecialAbility()
        {
            Damage += 5;
        }

        public override void EndingSpecialAbility()
        {
            Damage -= 5;
        }
    }
}
