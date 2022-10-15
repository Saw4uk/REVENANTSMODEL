﻿using System;

namespace Assets.Scripts.Model
{
    public abstract class Cloth : Item
    {
        protected readonly int MaxArmor;
        public float Armor { get; protected set; }
        public readonly Inventory Inventory;


        protected Cloth(int maxArmor, Inventory inventory)
        {
            MaxArmor = maxArmor;
            Inventory = inventory;
        }

        public float CalculateBlockedDamage(Shoot shoot)
        {
            //TODO еще одна умная формула
            throw new NotImplementedException();
        }
    }
}