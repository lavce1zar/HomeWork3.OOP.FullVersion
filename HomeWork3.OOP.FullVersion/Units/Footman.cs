using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.OOP.FullVersion.Units
{
    public class Footman : Unit
    {
        public override string Name => "Footman";

        public override int Cost => 135;

        public override string DamageType => "Physical";

        public Footman()
        {
            Health = 420;
            Damage = 13;
            Armor = 2;
        }

        public override void TakingHealing()
        {
            if (Health > 420)
            {
                Health = 420;
            }
        }

        public override void UsingSpecialAbility()
        {
            Armor += 6;
        }

        public override void EndingSpecialAbility()
        {
            Armor = 2;
        }
    }
}
