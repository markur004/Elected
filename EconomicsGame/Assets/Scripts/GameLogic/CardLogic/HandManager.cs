using System.Collections.Generic;
using UnityEngine;

namespace GameLogic.CardLogic
{
    public class HandManager : MonoBehaviour
    {
            public static HandManager Instance;
            public Transform handArea; // np. layout group
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
                GameObject newCard = Instantiate(cardPrefab, handArea);
                newCard.GetComponent<CardDisplay>().SetCard(cardData);
            }
    }
}