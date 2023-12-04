using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHandController : MonoBehaviour
{
    private float speed = 10;
    private int minX, maxX, minZ, maxZ;


    void Start()
    {
        minX = -1;
        minZ = -1;
        maxX = 10;
        maxZ = 10;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && this.transform.position.z < maxZ)
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
