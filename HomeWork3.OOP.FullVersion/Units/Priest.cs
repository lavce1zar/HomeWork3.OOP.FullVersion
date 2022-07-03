using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.OOP.FullVersion.Units
{
    public class Priest : Unit, IHealable
    {
        public override string Name => "Priest";

        public override int Cost => 140;

        public static int Healing => 25;

        public override string DamageType => "Magical";

        public Priest()
        {
            Health = 290;
            Damage = 9;
            Armor = 0;
        }

        public void Heal(Unit unit)
        {
            unit.Health += Healing;
            unit.TakingHealing();
        }

        public override void TakingHealing()
        {
            if (Health > 290)
            {
                Health = 290;
            }
        }

        public override void UsingSpecialAbility()
        {
            Health += 120;
        }

        public override void EndingSpecialAbility()
        {
            Health -= 120;
        }
    }
}
