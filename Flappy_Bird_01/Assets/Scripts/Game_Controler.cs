using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Controler : MonoBehaviour
{
    Pipe_Controler _Pipe_Controler;
    void Start()
    {
       _Pipe_Controler = FindObjectOfType<Pipe_Controler>();
       _Pipe_Controler.Inset_pipe();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
