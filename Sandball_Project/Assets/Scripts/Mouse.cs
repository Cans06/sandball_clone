using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    CircleCollider2D col;
    public Camera Kamera;
    public Transform top;
    void Start()
    {
        col = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            col.enabled = true;
            col.transform.position = (Vector2)Kamera.ScreenToWorldPoint(Input.mousePosition);
        }
        else
        {
            col.enabled = false;
        }
        Physics2D.IgnoreCollision(top.GetComponent<CircleCollider2D>(), GetComponent<CircleCollider2D>());

    }

}
