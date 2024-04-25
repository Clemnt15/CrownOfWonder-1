using System;
using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    [SerializeField] CinemachineVirtualCamera Main_Camera;
    [SerializeField] CinemachineVirtualCamera Global_Camera;
    [SerializeField] bool isMainCamera = true;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D()
    {
        Debug.Log("Hello World");
        if (isMainCamera == true)
        {
            Global_Camera.Priority = 3;
            isMainCamera = false;
        }
        else
        {
            Global_Camera.Priority = 1;
            isMainCamera = true;
        }
        
    }

    void OnTriggerExit2D()
    {
        Debug.Log("Bye World");
    }
 
}
