using System.Collections.Generic;
using Assets.Scripts.Model.Items.Weapons.Guns;

namespace Assets.Scripts.Model.Items.Weapons.Guns
{
    public abstract class Magazine
    {
        private Stack<Ammo> ammoStack;
        private List<Caliber> AviableCalibers;
        public int Cpacity { get; set; } = 0;
    }
}