namespace Assets.Scripts.Model
{
    public abstract class Entity
    {
        public readonly Body Body;
        private Weapon primaryGun;
        private Weapon secondaryGun;
        private Weapon meleeWeapon;
        private Weapon chosenWeapon;
        public void Attack(Weapon weapon, Body target)
        {
            //Стрельба из gun по target вызывает у gun метод стрельбы, который формирует служебный класс Shoot
        }

    }
}