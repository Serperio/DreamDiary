using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsBehaviour : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        print("Quitting");
        return;
    }
    public void ChangeScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
        return;
    }
    public void LoadingGame()
    {
        print("Cargar Partida");
    }

}
