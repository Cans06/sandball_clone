using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arac : MonoBehaviour
{
    
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "top")
        {
            GameManager.x++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
