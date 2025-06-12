using System.Collections.Generic;
using GameLogic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    
    public class GamePlayUIHandler : MonoBehaviour
    {
        [SerializeField] private List<Text> MainLabelValues;
        public static GamePlayUIHandler Instance;
        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);

            DontDestroyOnLoad(gameObject);
        }

        public void SetIndexesUI(Indexs indexs)
        {
            MainLabelValues[0].text = ((int)indexs.GDP).ToString() + " bln";
            MainLabelValues[1].text = ((int)indexs.budget).ToString() + " mld";
            MainLabelValues[2].text = ((int)indexs.population).ToString() + " mln";

        }

        public void NextRound()
        {
            GameManager.Instance.NextTurn();
        }
    }


}