using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveMenu : MonoBehaviour
{
    [SerializeField]
    Button first;
    // Start is called before the first frame update
    public void ConfirmSave()
    {
        gameObject.SetActive(false);
        print("Guardar");
    }
    public void CloseMenu()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        first.Select();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            gameObject.SetActive(false);
        }
    }
}
