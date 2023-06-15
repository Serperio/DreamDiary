using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Efecto : MonoBehaviour
{
    public int ID;
    public string Nombre;

    public abstract void ejecutarEfecto();
}
