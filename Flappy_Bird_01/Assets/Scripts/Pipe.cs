using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float moving_speed;     // Vận tốc di chuyển
    Pipe_Controler _Pipe_Controler;

    // Start is called before the first frame update
    void Start()
    {
        moving_speed = (moving_speed / 10000);
        _Pipe_Controler = FindObjectOfType<Pipe_Controler>();
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(moving_speed, 0, 0);

        if (transform.position.x < -3.26)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < 1.42 + (Time.deltaTime/1.25) && transform.position.x > 1.42)
        {
            _Pipe_Controler.Inset_pipe();
        }
       


    }


    //SỰ KIỆN NHÂN VẬT CHẠM VỚI VẬT CẢN
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Location_plus_points"))
        {
            Debug.Log("Pass");

        }
    }
}
