using System.Collections.Generic;
using UnityEngine;

namespace GameLogic
{
    public class DecisionSystem : MonoBehaviour
    {
        public static DecisionSystem Instance;
        [SerializeField]private List<EventCard> Cards;
        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);

            DontDestroyOnLoad(gameObject);
        }

        public void DrawEventCard()
        {
            Debug.Log("DUPA");
        }
    }
}