namespace Assets.Scripts.Model
{
    public abstract class Medicament : Item
    {
        // можно создать интерфейс IMedicament в котором будет метод Use(Health target)
        // пример реализации:
        // interface IMedicament
        // {
        //     public void Use(Health target);
        // }
        
        // class CoughPills: Item, IMedicament
        // {
        //     public void Use(Health target)
        //     {
        //         // TODO изменит здоровье
        //         throw new NotImplementedException();
        //     }
        // }
        
        
        private List<HealthProperties> PossibleToHealHealthPropertiesList;
        private List<HealthProperties> AdditionalHealHealthPropertiesList;
        private float ExtraRadiation;

        public void Use(Health target)
        {
            //TODO метод должен убирать у тела свойства из списка Possible... и добавлять свойства из списка Additional...
        }
    }
} 