using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject creditosGameObject;

    public void GameScene()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void VolverMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void IrCreditos()
    {
        creditosGameObject.SetActive(true);
    }

    public void VolverCreditos()
    {
        creditosGameObject.SetActive(false);
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
