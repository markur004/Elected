using UnityEngine;
using UnityEngine.UI;

namespace GameLogic.CardLogic
{
    public class CardDisplay : MonoBehaviour
    {
        public Image artwork;
        public Text nameText;
        public Text descriptionText;

        [SerializeField] private Toggle[] _decisionGroup;
        [SerializeField] private Text _decision1; 
        [SerializeField] private Text _decision2; 
        [SerializeField] private Text _decision3; 

        private EventCard cardData;

        public void SetCard(EventCard card)
        {
            cardData = card;
            artwork.sprite = card.image;
            nameText.text = card.title;
            descriptionText.text = card.description;
            _decision1.text = card.decisions[0].decisionText;
            _decision2.text = card.decisions[1].decisionText;
            _decision3.text = card.decisions[2].decisionText;
        }

        public Decision ChosenDecision()
        {
            int i = 0;
            foreach (var toggle in _decisionGroup)
            {
                if (toggle.isOn)
                {
                    return cardData.decisions[i];
                }
                i++;
            }
            return cardData.decisions[0];
        }
    }
}