using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Efecto : MonoBehaviour
{
    public int ID;
    public string nombre;
    public Sprite nuevoSprite;

    public abstract void EjecutarEfecto();

    public void ChangeSprite(){
        Debug.Log("Cambiar sprite");
    }
}
