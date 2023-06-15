using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float moveSpeed = .5f;
    public Transform movePoint;
    [SerializeField]
    LayerMask whatStopMovement;

    // Start is called before the first frame update
    void Start() {
        movePoint.parent = null;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, movePoint.position) <= .5f)
        {
            float HorizontalAxis = Input.GetAxisRaw("Horizontal");
            float VerticalAxis = Input.GetAxisRaw("Vertical");
            if (Mathf.Abs(HorizontalAxis) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .1f, whatStopMovement))
                {
                    movePoint.position += new Vector3(HorizontalAxis, 0f, 0f);

                }
            }
            else if (Mathf.Abs(VerticalAxis) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .1f, whatStopMovement))
                {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                }
            }
        }
        else if(Vector3.Distance(transform.position, movePoint.position) > 6f)
        {
            movePoint.position = transform.position;
        }
    }
}

/*    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}*/
