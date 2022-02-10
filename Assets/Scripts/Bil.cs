using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bil : MonoBehaviour
{
    public float speed = 2;
    private Vector3 StartPosition;
    void Start()
    {
        StartPosition = transform.position;  
    }

    void Update()
    {
        transform.Translate(translation:Vector3.down*speed*Time.deltaTime);
        if (transform.position.y < -30.33f){
            transform.position = StartPosition;
        }
    }
}
