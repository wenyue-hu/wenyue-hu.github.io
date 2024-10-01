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
        if (transform.position.y >= 20)
        {
            transform.position = new Vector3(transform.position.x,20,0);
        }
        else if(transform.position.y <= -4.3f)
        {
            transform.position = new Vector3(transform.position.x,-4.3f,0);
        }
    }
}
