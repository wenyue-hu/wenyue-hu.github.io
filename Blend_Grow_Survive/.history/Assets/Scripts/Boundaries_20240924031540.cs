using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 10)
        {
            transform.position = new Vector3(transform.position.x,10,0);
        }
        else if(transform.position.y <= -10)
        {
            transform.position = new Vector3(transform.position.x,-10,0);
        }

        if (transform.position.x >= 10)
        {
            transform.position = new Vector3(transform.position.x,10,0);
        }
        else if(transform.position.x <= -10)
        {
            transform.position = new Vector3(transform.position.x,-10,0);
        }
    }
}
