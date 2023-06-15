using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractTrigger : MonoBehaviour
{
    void Update()
    {
        float HorizontalAxis = Input.GetAxisRaw("Horizontal");
        float VerticalAxis = Input.GetAxisRaw("Vertical");
        if (Mathf.Abs(HorizontalAxis) == 1f)
        {
            transform.localPosition = new Vector3(HorizontalAxis, 0, 0);
        }
        else if (Mathf.Abs(VerticalAxis) == 1f)
        {
            transform.localPosition = new Vector3(0, VerticalAxis, 0);
        }
    }
}
