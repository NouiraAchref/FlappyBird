using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float limit,speed=1;
    private float lengthground;
    private BoxCollider2D x;
    // Start is called before the first frame update
    void Start()
    {   if(gameObject.CompareTag("ground"))
        {
            x = GetComponent<BoxCollider2D>();
        lengthground = x.size.x;
    }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        if (gameObject.CompareTag("ground"))
        {
            if (transform.position.x<=-lengthground)
        {
            transform.position = new Vector2(transform.position.x+ lengthground * 2, transform.position.y);
        }
        }
        if (gameObject.CompareTag("pipe"))
        {if (transform.position.x<limit)
            {
                Destroy(gameObject);
            }
        }
    }
}
