using UnityEngine;

[CreateAssetMenu(fileName = "SpyMelee",
    menuName = "Cards/Units/Spy Melee")]
public class SpyMeleeCard : UnitCard, IMeleeFighter, ISpy
{
    public SpecialAbilityType AbilityType =>
        SpecialAbilityType.Spy;

    public void ApplySpecialAbility()
    {
        Debug.Log("Шпион позволяет взять две карты!");
    }

    public override void Apply()
    {
        ApplyPowerPoints();
        ApplySpecialAbility();
    }
}
