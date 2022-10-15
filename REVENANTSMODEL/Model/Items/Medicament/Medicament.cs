namespace Assets.Scripts.Model
{
    public abstract class Medicament : Item
    {
        private List<HealthProperties> PossibleToHealHealthPropertiesList;
        private List<HealthProperties> AdditionalHealHealthPropertiesList;
        private float ExtraRadiation;

        public void Use(Health target)
        {
            //TODO метод должен убирать у теля свойства из списка Possible... и добавлять свойства из списка Additional...
        }
    }
} 