using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   public GameObject pipe;
    public float maxT, max, min;
    private float timer=0;

    // Start is called before the first frame update
    void Start()
    {
        spawner();
        
    }

    // Update is called once per frame
    void Update()
    {if(timer>=maxT)
        {
            spawner();
            timer = 0;
        }
        timer += Time.deltaTime;

    }
    void spawner()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = new Vector2(transform.position.x, Random.Range(min, max));

    }
    
}
