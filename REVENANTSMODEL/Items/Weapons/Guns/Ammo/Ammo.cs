namespace Assets.Scripts.Model
{
    // Патрон не наследуется от класса предмета, патроны будут хранится в коробках, которые будут отображаться в инвентаре
    public abstract class Ammo
    {
        public Caliber Caliber { get; protected init; }
        public float Damage { get; protected init; }
        public float ExtraFireDistance { get; protected init; }
        public float ArmorPenetrating { get; protected init; }
        public float BoneBreakingChance { get; protected init; }
        public float BleedingChance { get; protected init; }
        public float Recoil { get; protected init; }
        public float ExtraAccuracy { get; protected init; }
        public float Noise { get; protected init; }
        public float Weight { get; protected init; }
    }
}