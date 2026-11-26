using UnityEngine;

[CreateAssetMenu(fileName = "CommandersHorn",
    menuName = "Cards/Special/Commanders Horn")]
public class CommandersHornCard : Card, IStrengthSurge
{
    public SpecialAbilityType AbilityType =>
        SpecialAbilityType.StrengthSurge;

    public void ApplySpecialAbility()
    {
        Debug.Log("Командный рог усиливает подразделение!");
    }

    public override void Apply()
    {
        ApplySpecialAbility();
    }
}
