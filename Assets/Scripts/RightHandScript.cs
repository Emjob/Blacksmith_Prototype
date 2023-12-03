using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandScript : MonoBehaviour
{
    private Vector3 Pos;
    private float Offset = 30f;
    void Start()
    {
        
    }


    void Update()
    {
        Pos = Input.mousePosition;
        Pos.z = Offset;
        transform.position = Camera.main.ScreenToWorldPoint(Pos);
    }
}
