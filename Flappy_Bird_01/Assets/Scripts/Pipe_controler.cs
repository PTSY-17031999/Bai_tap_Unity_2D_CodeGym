using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_controler : MonoBehaviour
{
    public float moving_speed;     // Vận tốc di chuyển
    Pipe_controler Pipe;

    // Start is called before the first frame update
    void Start()
    {
        moving_speed = (moving_speed / 10000);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(moving_speed, 0, 0);

/*
        if (transform.position.x > 5.0 && transform.position.x < 5.0 + moving_speed)
        {
            //Pipe.CreateCloud();

        }
        if (transform.position.x > 11.2)
        {
            Destroy(gameObject);
        }*/
    }
}
