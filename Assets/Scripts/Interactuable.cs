using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactuable : MonoBehaviour
{
    [SerializeField]
    string tagKill;
    [SerializeField]
    EfectoAsesino efectoAsesino;

    bool talking;
    // Start is called before the first frame update
    void Start()
    {
        talking = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && talking)
        {
            Debug.Log("Interacting");
            if(gameObject.tag == tagKill && efectoAsesino.efectoActivado()){
                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "face")
        {
            talking = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "face")
        {
            talking = false;
        }
    }
}
