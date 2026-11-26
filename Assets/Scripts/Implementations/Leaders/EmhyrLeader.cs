using UnityEngine;

[CreateAssetMenu(fileName = "EmhyrLeader",
    menuName = "Cards/Leaders/Emhyr")]
public class EmhyrLeader : LeaderCard
{
    public override void ApplyUltimate()
    {
        Debug.Log("Эмгыр вар Эмрейс применяет ультимативную способность!");
    }
}
