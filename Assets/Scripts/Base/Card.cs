
using UnityEngine;

public abstract class Card : ScriptableObject
{
    [SerializeField] private string cardName;
    [SerializeField] private Sprite icon;
    [TextArea(3, 5)]
    [SerializeField] private string description;

    public string CardName => cardName;
    public Sprite Icon => icon;
    public string Description => description;

    public abstract void Apply();
}
