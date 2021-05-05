using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class move : MonoBehaviour
{

    float speed = 0.00001f;
    private Rigidbody rb;
    public Transform PlayerTransform;
    private Vector3 _cam;
    // [Range(0.01f, 1.0f)]
    // Start is called before the first frame update
    void Start()
    {
        //_cam = transform.position - PlayerTransform.position;
    }
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        speed = speed + 0.08f;
    }
    // Update is called once per frame
    



   //
    void Update()
    {
       
        if (Input.GetKey(KeyCode.UpArrow))
        {
            
            rb.transform.Translate(Vector3.forward * speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            /*
            if(speed>0)
            {
                speed = speed - 0.00001f;
            }*/

            
                rb.transform.Translate(Vector3.back * speed);
            
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.transform.Rotate(Vector3.down, 3);
           
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.transform.Rotate(Vector3.up, 3);
        }

        

        
       
        
    }
}
