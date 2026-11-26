using UnityEngine;

public abstract class LeaderCard : Card, ILeader
{
    public abstract void ApplyUltimate();

    public override void Apply()
    {
        ApplyUltimate();
    }
}
