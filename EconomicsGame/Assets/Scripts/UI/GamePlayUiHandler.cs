using System;
using System.Collections.Generic;
using GameLogic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    
    public class GamePlayUIHandler : MonoBehaviour
    {
        [SerializeField] private List<Text> MainLabelValues;
        [SerializeField] private Slider HappinesSlider;
        [SerializeField] private Slider CorruptionSlider;
        public static GamePlayUIHandler Instance;
        [SerializeField] private Slider _soundSlider;
        [SerializeField] private GameObject OptionsMenu;
        [SerializeField] private Button nextRoundButton;
        [SerializeField] private Text pollutionText;
        [SerializeField] private Text CurrencyText;
        [SerializeField] private GameObject Lore;
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
            HappinesSlider.value = indexs.publicSupport;
            CorruptionSlider.value = indexs.corruption;
            pollutionText.text = "pollution: " + CalculateStatus(indexs.pollution);
            CurrencyText.text = "currency value:  " + CalculateStatus(indexs.currencyValue);
        }
        
        public void NextRound()
        {
            SoundManager.Instance.ButtonPressed();
            if (GameManager.Instance.currentTurn == 1)
            {
                Lore.SetActive(false);
            }

            GameManager.Instance.NextTurn();
        }
        public void OpenOptions()
        {
            SoundManager.Instance.ButtonPressed();
            nextRoundButton.interactable = false;
            OptionsMenu.SetActive(true);
            _soundSlider.value = SoundManager.Instance.currentVolume;
        }
        
        public void CloseOptions()
        {
            SoundManager.Instance.ButtonPressed();
            OptionsMenu.SetActive(false);
            nextRoundButton.interactable = true;
        }
        
        public void AudioSlider()
        {
            SoundManager.Instance.Volume(_soundSlider.value);
        }
        
        public void Exit()
        {
            SoundManager.Instance.ButtonPressed();
            Application.Quit();
        }

        public String CalculateStatus(float value)
        {
            if (value > 70f)
            {
                return "High";
            }
            
            if(value > 30f)
            {
                return "Medium";
            }

            return "Low";
        }
    }


}