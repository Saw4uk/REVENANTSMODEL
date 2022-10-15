using System;

namespace Assets.Scripts.Model
{
    public abstract class Cloth : Item
    {
        protected int MaxArmor { get;  init; }
        public float CurrentArmor { get; protected set; }
        public readonly Inventory Inventory;
        public float TotalWeight => Weight + Inventory.Items.Sum(item => item.Weight);

        protected Cloth(Inventory inventory)
        {
            Inventory = inventory;
        }

        public float CalculateBlockedDamage(Shoot shoot)
        {
            //TODO расчитать колличество заблокированного урона
            throw new NotImplementedException();
        }
    }
}