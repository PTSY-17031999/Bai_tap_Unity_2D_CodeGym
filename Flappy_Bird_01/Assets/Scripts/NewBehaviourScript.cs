using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Awake()
    {//  Debug.Log("Awake");
    }
    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log("Star");
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log("Update");
    }
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
}
