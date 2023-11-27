using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Transformation : MonoBehaviour
{
    private float Heat;
    private bool Heating, Heated;
    private Vector3 ScaleChange, rotateChange;
    public bool Rotated;

    // Start is called before the first frame update
    void Start()
    {
        ScaleChange = new Vector3 (0.5f, -0.2f, 0.2f);
        rotateChange = new Vector3(0.5f, 0.2f, -0.2f);
    }

    // Update is called once per frame
    void Update()
    {
       Heat = Mathf.Clamp(Heat, 0, 20);
        
        if(Heat >= 10)
        {
            Heated = true;
        } else
        {
            Heated = false;
        }
        if(Input.GetKeyDown(KeyCode.E) && Heated)
        {
            if(Rotated)
            {
                ScaleChangeTwo();
            }
            if(!Rotated)
            {
                ScaleChangeOne();
            }
            
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            transform.Rotate(90, 0, 0);
            Rotated = !Rotated;
        }
        
    }
    private void FixedUpdate()
    {
        if (!Heating)
        {
            Heat -= 0.3f;
        }
        if (Input.GetKey(KeyCode.H))
        {
            Heat += 1;
            Heating = true;
        }
        else
        {
            Heating = false;
        }
    }

    private void ScaleChangeOne()
    {
        transform.localScale += ScaleChange;
    }
    private void ScaleChangeTwo()
    {
        transform.localScale += rotateChange;
    }
}
