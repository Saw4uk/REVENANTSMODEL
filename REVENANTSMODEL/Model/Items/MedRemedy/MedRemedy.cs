namespace Assets.Scripts.Model{
    public abstract class MedRemedy : Item
    {
        private bool IsHealingBleeding;
        private bool IsHealingBroke;
        private float ExtraHp;

        public void Use(BodyPart target)
        {
            //TODO у target добавить хп и убрать свойсвтва кровотечения и перелома в зависимости от бул свойств
        }
    }
}