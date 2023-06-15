using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EfectoNexo : Efecto
{
    [SerializeField]
    int Scene = 0;

    public override void EjecutarEfecto(){
        SceneManager.LoadScene(Scene);
    }
}
