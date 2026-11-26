using UnityEngine;

public abstract class UnitCard : Card, IPowerPoints, IRare
{
    [SerializeField] private int powerPoints;
    [SerializeField] private bool isRare;

    public int PowerPoints => powerPoints;
    public bool IsRare => isRare;

    public void ApplyPowerPoints()
    {
        Debug.Log($"Сила карты: {PowerPoints}");
    }

    public override void Apply()
    {
        ApplyPowerPoints();
    }
}
