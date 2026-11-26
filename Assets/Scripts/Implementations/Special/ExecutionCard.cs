using UnityEngine;

[CreateAssetMenu(fileName = "Execution",
    menuName = "Cards/Special/Execution")]
public class ExecutionCard : Card, IExecution
{
    public SpecialAbilityType AbilityType =>
        SpecialAbilityType.Execution;

    public void ApplySpecialAbility()
    {
        Debug.Log("Применена способность Казнь!");
    }

    public override void Apply()
    {
        ApplySpecialAbility();
    }
}
