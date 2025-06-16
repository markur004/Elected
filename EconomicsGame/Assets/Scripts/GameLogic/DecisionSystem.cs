using System.Collections.Generic;
using GameLogic.CardLogic;
using UnityEngine;

namespace GameLogic
{
    public class DecisionSystem : MonoBehaviour
    {
        public static DecisionSystem Instance;
        [SerializeField]public List<EventCard> Cards;
        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);

            DontDestroyOnLoad(gameObject);
        }

        public void DrawEventCard()
        {
            int i = Random.Range(0, Cards.Count);
            EventCard card = Cards[i];
            Debug.Log(card.title);
            HandManager.Instance.DrawCard(card);
            Cards.RemoveAt(i);
        }

        public Decision CheckDecision()
        {
           return HandManager.Instance.currentCard.ChosenDecision();
        }
    }
}