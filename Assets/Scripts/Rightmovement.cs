using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rightmovement : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    [SerializeField]
    bool horizontal;
    [SerializeField]
    int dir;
    // Start is called before the first frame update
    void Start()
    {
        if (horizontal)
        {
            rb.velocity =new Vector2( 2f*dir, 0f);
        }
        else
        {
            rb.velocity = new Vector2(0f, 2f*dir);
        }
    }
}
