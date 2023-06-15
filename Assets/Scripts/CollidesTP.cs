using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidesTP : MonoBehaviour
{
    [SerializeField]
    Transform boxTransform;
    [SerializeField]
    Transform origin;
    [SerializeField]
    bool horizontal;
    [SerializeField]
    int dir;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (horizontal) collision.gameObject.transform.position = new Vector2( origin.position.x+dir*boxTransform.localScale.x, collision.gameObject.transform.position.y);
        else collision.gameObject.transform.position = new Vector2(collision.gameObject.transform.position.x, origin.position.y+dir * boxTransform.localScale.y);
    }
}
