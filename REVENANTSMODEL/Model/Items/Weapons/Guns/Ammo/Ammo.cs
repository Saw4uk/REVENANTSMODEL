namespace Assets.Scripts.Model.Items.Weapons.Guns
{
    public enum Caliber
    {
        FiveFortyFive,
        SexSeventyTwo,
        NineNineteen,
        NineEighteen
    }
    public abstract class Ammo
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