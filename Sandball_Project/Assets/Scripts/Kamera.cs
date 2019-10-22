using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    

  public  GameObject top;
  private  Vector3 fark;
    float x;

    // Use this for initialization
    void Start()
    {
        //top= GameObject.FindWithTag("top");
        fark = this.transform.position - top.transform.position;

        //aradaki farkı buluyoruz
    }

    // Update is called once per frame
    void Update()

    {
        
        if (Input.GetAxisRaw("Mouse Y") <= 0f && Input.GetMouseButton(0))
        {
            x = Input.GetAxisRaw("Mouse Y");


        }
        if (this.transform.position.y > -7.0f && Input.GetMouseButton(0))
        {
            transform.position += new Vector3(0f, x * Time.deltaTime * 0.65f, 0f);
        }
        





    }
}
