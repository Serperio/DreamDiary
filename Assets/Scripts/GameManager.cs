using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    SaveLoad saveLoad;
    public EfectosData efectos;
    public static GameManager Instance; // A static reference to the GameManager instance

    void Awake()
    {
        if (Instance == null) // If there is no instance already
        {
            DontDestroyOnLoad(gameObject); // Keep the GameObject, this component is attached to, across different scenes
            Instance = this;
        }
        else if (Instance != this) // If there is already an instance and it's not `this` instance
        {
            Destroy(gameObject); // Destroy the GameObject, this component is attached to
        }
    }

    public void QuitGame()
    {
        Application.Quit();
        print("Quitting");
        return;
    }
    public void ChangeScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
        return ;
    }
    public void LoadingGame()
    {
        efectos = saveLoad.LoadState();
        ChangeScene(2);
        print("Cargar Partida");
    }
}
