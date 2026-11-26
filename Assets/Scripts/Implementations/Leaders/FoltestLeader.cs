using UnityEngine;

[CreateAssetMenu(fileName = "FoltestLeader",
    menuName = "Cards/Leaders/Foltest")]
public class FoltestLeader : LeaderCard
{
    public override void ApplyUltimate()
    {
        Debug.Log("Фольтест применяет ультимативную способность!");
    }
}
