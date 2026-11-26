
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class CardPool
{
    private ObjectPool<Card> pool;

    private readonly Queue<Card> availableCards = new();
    private readonly List<Card> deck = new();

    public IReadOnlyList<Card> Deck => deck;

    public void Initialize(Card[] cardAssets)
    {
        foreach (Card asset in cardAssets)
        {
            if (asset == null)
                continue;

            Card card = Object.Instantiate(asset);

            availableCards.Enqueue(card);
            deck.Add(card);

            LogCard(card);
        }

        pool = new ObjectPool<Card>(
            () => availableCards.Dequeue(),
            null,
            null,
            card => Object.Destroy(card),
            true,
            deck.Count,
            deck.Count
        );

        // Возвращаем все созданные карты в пул.
        for (int i = 0; i < deck.Count; i++)
        {
            Card card = pool.Get();
            pool.Release(card);
        }

        Debug.Log($"Колода инициализирована. Всего карт: {deck.Count}");
    }

    public Card GetCard()
    {
        if (pool == null || pool.CountInactive == 0)
        {
            Debug.LogWarning("В пуле нет свободных карт!");
            return null;
        }

        return pool.Get();
    }

    public void ReturnCard(Card card)
    {
        pool.Release(card);
    }

    private void LogCard(Card card)
    {
        string placement = "Не определено";
        string ability = "Нет";
        string additionalInfo = "";

        if (card is IArcher)
            placement = "Дальний бой";
        else if (card is IMeleeFighter)
            placement = "Ближний бой";
        else if (card is ISiegeWeapon)
            placement = "Осадное орудие";
        else if (card is ILeader)
            placement = "Лидер";
        else if (card is IWeatherCard)
            placement = "Погода";

        if (card is ISpecialAbility special)
            ability = special.AbilityType.ToString();

        if (card is IPowerPoints power)
            additionalInfo += $" | Очки силы: {power.PowerPoints}";

        if (card is IRare rare && rare.IsRare)
            additionalInfo += " | Редкая карта";

        if (card is ILeader)
            additionalInfo += " | Карта лидера";

        if (card is IWeatherCard)
            additionalInfo += " | Погодная карта";

        Debug.Log(
            $"Создана карта {card.CardName}; " +
            $"описание: {card.Description}; " +
            $"тип размещения: {placement}; " +
            $"специальная способность: {ability}" +
            additionalInfo
        );
    }
}
