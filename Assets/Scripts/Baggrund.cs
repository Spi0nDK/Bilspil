using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baggrund : MonoBehaviour
{
    public float speed = 4;
    private Vector3 StartPosition;
    void Start()
    {
        StartPosition = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(translation:Vector3.down*speed*Time.deltaTime);
        if (transform.position.y < -30.1f){
            transform.position = StartPosition;
        }
    }
}
