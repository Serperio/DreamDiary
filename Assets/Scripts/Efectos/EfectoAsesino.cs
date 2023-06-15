using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoAsesino : Efecto
{

    enum Estado {activo, inactivo};
    Estado estado = Estado.inactivo;

    public override void EjecutarEfecto(){
        estado = Estado.activo;
    }

    public override void QuitarEfecto(){
        estado = Estado.inactivo;
    }

    public bool efectoActivado(){
        return estado == Estado.activo;
    }
}
