using System;
using GameLogic;
using GameLogic.CardLogic;
using UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Indexs CountryStats;
    public int currentTurn = 1;
    private int maxTurns = 12;



    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public void Start()
    {
        CountryStats = new Indexs();
        GamePlayUIHandler.Instance.SetIndexesUI(CountryStats);
    }

    public void NextTurn()
    {
        if (currentTurn > 1)
        {
            Decision decision = DecisionSystem.Instance.CheckDecision();
            CountryStats.ApplayChanages(decision);
        }
        currentTurn++;
        GamePlayUIHandler.Instance.SetIndexesUI(CountryStats);
        if (currentTurn > maxTurns || CountryStats.IsCritical())
        {
            EndGame();
        }
        else
        {
            Debug.Log($"Tura {currentTurn} rozpoczęta.");
            DecisionSystem.Instance.DrawEventCard();
        }
    }
    private void EndGame()
    {
        Debug.Log("Koniec gry. Wyświetl zakończenie.");
        //statyczna klasa ktora zwroci jaki ending odgrac albo 3 sceny po gamersku like a boss - like a boss B)
        if (currentTurn < maxTurns)
        {
            SceneManager.LoadScene("EndingScene");
        }
        else
        {
            SceneManager.LoadScene("EndingSceneWon");
        }


    }
}

