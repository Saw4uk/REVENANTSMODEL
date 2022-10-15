namespace Assets.Scripts.Model
{
    public abstract class Magazine : Item
    {
        protected Stack<Ammo> AmmoStack;
        protected List<Caliber> AviableCalibers;//TODO Загрузка патрона в магазин возможна только в случае, если калибр патрона доступен
        protected int Capacity;//TODO Нельзя загрузить больше патронов чем Capacity
        public bool IsEmpty => AmmoStack.Count == 0; 

        public Ammo DeLoad()
        {
            return AmmoStack.Pop();
        }

        public void Reload(List<Ammo> ammoList)
        {
            foreach (var ammo in ammoList)
                AmmoStack.Push(ammo);
        }
    }
}