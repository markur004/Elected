using System.Collections.Generic;
using UnityEngine;

namespace GameLogic.CardLogic
{
    public class HandManager : MonoBehaviour
    {
            public static HandManager Instance;
            public GameObject newCard;
            public Transform handArea;
            public CardDisplay currentCard;
            public GameObject cardPrefab;
            public List<EventCard> cardsInHand = new();
            
            private void Awake()
            {
                if (Instance == null) Instance = this;
                else Destroy(gameObject);

                DontDestroyOnLoad(gameObject);
            }
        
            public void DrawCard(EventCard cardData)
            {
                Destroy(newCard);
                newCard = Instantiate(cardPrefab, handArea);
                currentCard = newCard.GetComponent<CardDisplay>();
                currentCard.SetCard(cardData);
            }
    }
}