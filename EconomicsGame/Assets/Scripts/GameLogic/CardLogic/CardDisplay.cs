using UnityEngine;
using UnityEngine.UI;

namespace GameLogic.CardLogic
{
    public class CardDisplay : MonoBehaviour
    {
        public Image artwork;
        public Text nameText;
        public Text descriptionText;

        private EventCard cardData;

        public void SetCard(EventCard card)
        {
            cardData = card;
            artwork.sprite = card.image;
            nameText.text = card.title;
            descriptionText.text = card.description;
            Debug.Log("Clicked on: " + cardData.title);
        }

        public void OnClick()
        {
            Debug.Log("Clicked on: " + cardData.title);
        }
    }
}