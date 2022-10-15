namespace Assets.Scripts.Model
{
    public abstract class Gun : Item
    {
        private Magazine currenMagazine;
        private Ammo Chamber;
        /* 
         * После патронника в реализации абстракных классов будут идти слоты для GunModule.
         * У каждого оружия будет свой допустимый набор возможных GunModules
         */
        private int FireRate;
        private float Accuracy;
        private float ExtraDamage;
        private float FireDistance;
        private float Ergonomics;//Чем выше, тем больше негативное влияние на Mobility класса персонажа

        public Shoot GiveShoot()
        {
            //TODO реализовать метод который возвращает служебный класс выстрела
            return default;
        }
    }
}
