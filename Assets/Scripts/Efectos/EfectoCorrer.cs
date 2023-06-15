using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoCorrer : Efecto
{
    [SerializeField]
    GameObject Player;
    [SerializeField]
    float maxSpeed;
    [SerializeField]
    float minSpeed;

    public override void EjecutarEfecto(){
        Player.GetComponent<PlayerMovement>().moveSpeed = maxSpeed;
    }

    public override void QuitarEfecto(){
        Player.GetComponent<PlayerMovement>().moveSpeed = minSpeed;
    }
}
