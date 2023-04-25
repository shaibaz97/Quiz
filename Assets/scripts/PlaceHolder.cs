using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceHolder : MonoBehaviour
{
    public bool canChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (!canChange)
            {
                GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.5f);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (!canChange)
            {
                GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.0862f);
            }
        }
    }
}
