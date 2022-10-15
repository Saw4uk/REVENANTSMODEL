namespace Assets.Scripts.Model
{
    class Bandage : Item, IMedRemedy
    {
        public void UseTo(BodyPart target)
        {
            // TODO убрать кровотечение
            throw new NotImplementedException();
        }
    }
}