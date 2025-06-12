using System.Collections.Generic;
using GameLogic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    
    public class GamePlayUIHandler : MonoBehaviour
    {
        //position in the list should be the same as Indexs object vaule - big brain programming
        [SerializeField] private List<Text> Values;
        public static GamePlayUIHandler Instance;
        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);

            DontDestroyOnLoad(gameObject);
        }

        public void SetIndexesUI(Indexs indexs)
        {
            foreach (var value in Values)
            {
                //todo: convert to sliders to avoid weird numbers :D
                value.text = indexs.GDP.ToString();
            }
        }

        public void NextRound()
        {
            GameManager.Instance.NextTurn();
        }
    }
}