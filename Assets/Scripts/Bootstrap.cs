using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private Card[] cardAssets;

    private CardPool cardPool;

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        cardPool = new CardPool();

        cardPool.Initialize(cardAssets);

        Debug.Log("Bootstrap: система карт успешно запущена!");

        Debug.Log($"Количество карт в колоде: " +
            cardPool.Deck.Count);
    }
}
