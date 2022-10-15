namespace Assets.Scripts.Model;

public abstract class GunModule : Item
{
    private readonly float DeltaRecoil;
    private readonly float DeltaAccuracy;
    private readonly float DeltaNoise;
    private readonly float DeltaAverageDistance;
    private readonly float DeltaDamage;
    private readonly float DeltaErgonomics;
}