using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void GameScene()
    {
        SceneManager.LoadScene("Level");
    }

    public void ContinueGame()
    {
        Debug.Log("Juego cargado");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
