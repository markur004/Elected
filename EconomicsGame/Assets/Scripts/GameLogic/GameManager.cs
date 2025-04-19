using System;
using GameLogic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Indexs CountryStats;
    public int currentTurn = 1;
    private int maxTurns = 16;



    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public void Start()
    {
        Indexs CountryStats = new Indexs();

    }

    public void NextTurn()
    {
        currentTurn++;

        if (currentTurn > maxTurns)
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
        SceneManager.LoadScene("EndingScene");
    }
}

