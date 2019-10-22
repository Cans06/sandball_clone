using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    private SpriteRenderer sr;
    private int rastgele;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        rastgele = Random.Range(0, 4);
        if (rastgele == 0)
        {
            sr.color = Color.red;
        }
        else if (rastgele == 1)
        {
            sr.color = Color.yellow;
        }
        else if (rastgele == 2)
        {
            sr.color = Color.blue;
        }
        else if (rastgele == 3)
        {
            sr.color = Color.green;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="arac")
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
