using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Transformation : MonoBehaviour
{
    
    private float changeSpeed, t, Heat;
    public GameObject cube;
    public Renderer ObjectRender;
    public Color coolColor, heatColor;
    private bool Heating, Heated;
    private Vector3 xChange,zChange, yChange;

    // Start is called before the first frame update
    void Start()
    {
        zChange = new Vector3 (0.2f, -0.2f, 0.2f);
        yChange = new Vector3(0.2f, 0.2f, -0.2f);
        xChange = new Vector3(-0.2f, 0.2f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {

       Heat = Mathf.Clamp(Heat, 0, 20);
        t = Mathf.Clamp(t, 0, 100);
        
        if(Heat >= 10)
        {
            Heated = true;
        } else
        {
            Heated = false;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            t = 0;
            Heating = !Heating;
        }

        if(cube.transform.localScale.x <= 0 || cube.transform.localScale.y <= 0 || cube.transform.localScale.z <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        BoxCollider collider = GetComponent<BoxCollider>();
        collider.size = cube.transform.localScale;
        if (!Heating)
        {
            
            Heat -= 0.3f;
            
            if (ObjectRender.material.color != coolColor)
            {
                t = t + (Time.deltaTime * changeSpeed);
                ObjectRender.material.color = Color.Lerp(ObjectRender.material.color, coolColor, t);
            }

        }
        if (Heating)
        {
            
            Heat += 0.3f;
             
            if (ObjectRender.material.color != heatColor)
            {
                t = t + (Time.deltaTime * changeSpeed);
                ObjectRender.material.color = Color.Lerp(ObjectRender.material.color, heatColor, t);
            }
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Hammer" && Heated)
        {
            Vector3 normal = collision.contacts[0].normal;

            if (normal == transform.forward)
            {
                Debug.Log("FORWARD");
                cube.transform.localScale += yChange;
            }

            else if (normal == -(transform.forward))
            {
                Debug.Log("BACKWARD");
                cube.transform.localScale += yChange;
            }

            else if (normal == transform.right)
            {
                Debug.Log("RIGHT");
                cube.transform.localScale += xChange;
            }

            else if (normal == -(transform.forward))
            {
                Debug.Log("LEFT");
                cube.transform.localScale += xChange;
            }

            else if (normal == transform.up)
            {
                Debug.Log("Down");
                cube.transform.localScale += zChange;
            }

            else if (normal == -(transform.up))
            {
                Debug.Log("Up");
                cube.transform.localScale += zChange;
            }
        }
        
    }

}
