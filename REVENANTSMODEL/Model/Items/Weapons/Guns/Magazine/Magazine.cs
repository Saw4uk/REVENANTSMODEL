namespace Assets.Scripts.Model
{
    public abstract class Magazine : Item
    {
        private Stack<Ammo> ammoStack;
        private List<Caliber> AviableCalibers;//TODO Загрузка патрона в магазин возможна только в случае, если калибр патрона доступен
        private readonly int Cpacity;//TODO Нельзя загрузить больше патронов чем Capacity
        private int CurrentAmmoAmount;//TODO При попытке достать несуществующий патрон ничего не происходит

        public Ammo DeLoad()
        {
            CurrentAmmoAmount -= 1;
            return ammoStack.Pop();
        }

        public void Reload(List<Ammo> ammoList)
        {
            foreach (var ammo in ammoList)
            {
                ammoStack.Push(ammo);
                CurrentAmmoAmount += 1;
            }
        }
    }
}