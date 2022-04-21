using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
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
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
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
                SceneManager.LoadScene("DieMenu");
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
    }

}
