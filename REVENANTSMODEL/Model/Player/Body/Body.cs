namespace Assets.Scripts.Model
{
    public abstract class Body
    {
        protected readonly List<BodyPart> bodyPaths;

        public float TotalHP => bodyPaths.Sum(path => path.Hp);
        public float TotalWeight => bodyPaths.Sum(path => path.)

        public readonly Health health;

        public void GetDamage(Shoot shoot)//Этот метод будет переопределяться в классе наследнике. Он должен распределить урон от класса Shoot по частям тела
        {

        }
    }
}