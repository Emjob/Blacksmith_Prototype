using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHandController : MonoBehaviour
{
    private float speed = 10;


    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up*speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)) 
        {
            transform.Translate(Vector3.left*speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down*speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            transform.Translate(Vector3.right*speed*Time.deltaTime);
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Grabbable")
            {
                
            }
        }
        
    }


}
