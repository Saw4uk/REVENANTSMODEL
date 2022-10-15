using System;

namespace Assets.Scripts.Model
{
    public class CoughPills : Item, IMedicament
    {
        public void UseTo(Health target)
        {
            // TODO изменит здоровье
            throw new NotImplementedException();
        }
    }
}