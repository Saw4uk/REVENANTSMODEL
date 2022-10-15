namespace Assets.Scripts.Model
{
    public abstract class Ammo // Патрон не наследуется от класса предмета, патроны будут хранится в коробках, которые будут отображаться в инвентаре
    {
        public readonly Caliber Caliber;
        public readonly float Damage;
        public readonly float ExtraFireDistance;
        public readonly float ArmorPenetrating;
        public readonly float BoneBreakingChance;
        public readonly float BleedingChance;
        public readonly float Recoil;
        public readonly float ExtraAccuravy;
        public readonly float Noise;
        public readonly float Weigth;
    }
}