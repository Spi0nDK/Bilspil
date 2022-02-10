using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a")){
            if (transform.position.x == -1.2f){
                transform.position = new Vector3(-3.5f, -2.95f, 0);
            }
            else if (transform.position.x == 1.2f)
            {
                transform.position = new Vector3(-1.2f, -2.95f, 0);
            }
            else if (transform.position.x == 3.5f)
            {
                transform.position = new Vector3(1.2f, -2.95f, 0);
            }
        }
        if (Input.GetKeyDown("d"))
        {
            if (transform.position.x == -3.5f)
            {
                transform.position = new Vector3(-1.2f, -2.95f, 0);
            }
            else if (transform.position.x == -1.2f)
            {
                transform.position = new Vector3(1.2f, -2.95f, 0);
            }
            else if (transform.position.x == 1.2f)
            {
                transform.position = new Vector3(3.5f, -2.95f, 0);
            }
        }
    }
}
