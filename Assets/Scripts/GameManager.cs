using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager inst;
    public static int score = 0;

    public enum gameState
    {
        Play,
        Pause,
        GameOver
    }
    private gameState currentState;

    private void Awake()
    {
        if (GameManager.inst == null)
        {
            GameManager.inst = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        switch (currentState)
        {
            case gameState.Play:
                Debug.Log("tareas del play");
                break;
            case gameState.Pause:
                Time.timeScale = 0;
                break;
            case gameState.GameOver:
                Time.timeScale = 0;
                break;
        }
    }

    public void SetCurrentState(gameState state)
    {
        currentState = state;
    }
    public gameState GetGameState()
    {
        return currentState;
    }

    public static void scorePlayer()
    {
        score = score + 1;
        Debug.Log(score);
    }
}
