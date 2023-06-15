using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EffectMenu : MonoBehaviour
{
    [SerializeField]
    GameObject menu;
    [SerializeField]
    PlayerMovement playerMovement;
    bool menuBool;
    [SerializeField]
    TMP_Text[] buttons;
    GameManager gameManager;
    [SerializeField]
    string[] efectosname;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        menuBool = false;
        if (gameManager.efectos != null)
        {
        for(int i =0; i<gameManager.efectos.Efectos.Count; i++)
        {
           buttons[gameManager.efectos.Efectos[i]].text=efectosname[gameManager.efectos.Efectos[i]];
        }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            menuBool = !menuBool;
            if (menuBool)
            {
                menu.SetActive(true);
                playerMovement.enabled = false;
            }
            else
            {
                menu.SetActive(false);
                playerMovement.enabled = true;
            }

        }
    }
}
