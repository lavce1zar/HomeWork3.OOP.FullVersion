using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.OOP.FullVersion.Units
{
    public abstract class Unit : IUnit, IComparable<Unit>
    {
        public abstract string Name { get; }
        public abstract int Cost { get; }
        public int Health { get; set; }
        public int Damage { get; protected set; }
        public int Armor { get; protected set; }
        public abstract string DamageType { get; }

        public bool _isDead = false;

        public virtual void Attack(Unit unit)
        {
            if (DamageType == "Magical")
            {
                unit.Health -= Damage;
            }
            else
            {
                unit.Health -= Damage - unit.Armor;
            }

            unit.TakingDamage();
        }

        public virtual void TakingDamage()
        {
            if (Health < 0)
            {
                _isDead = true;
            }
        }

        public abstract void TakingHealing();

        public abstract void UsingSpecialAbility();

        public abstract void EndingSpecialAbility();

        public static void Fight(Unit unit1, Unit unit2)
        {
            unit1.UsingSpecialAbility();
            unit2.UsingSpecialAbility();
            unit1.Attack(unit2);
            unit2.TakingDamage();
            unit1.EndingSpecialAbility();
            unit2.EndingSpecialAbility();
        }

        public override string ToString()
        {
            return $"{Name}, Cost: {Cost}, Health: {Health}, Damage: {Damage}, DamageType: {DamageType}, Armor: {Armor}";
        }

        public int CompareTo(Unit? other)
        {
            return Damage.CompareTo(other?.Damage);
        }
    }
}
