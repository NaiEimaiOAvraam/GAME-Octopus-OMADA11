using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float limit = 9;
    public float speed = 0.8f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0.001f, 0, 0);  kounaei to object 0,001float to frame 
        transform.Translate(Time.deltaTime*Input.GetAxis("Horizontal")*speed, 0, 0); //xeirismos dejia aristera
        transform.Translate(0 , Time.deltaTime * Input.GetAxis("Vertical")*speed, 0); //xeirismos panw katw
        
        
        
        
        if (transform.position.x>limit) //limit dejia
        {
            Vector3 v = transform.position;
            v.x = limit;
            transform.position = v;
        }
        if (transform.position.x < -limit) // limit aristera
        {
            Vector3 v = transform.position;
            v.x = -limit;
            transform.position = v;
        }


        if (Input.GetButtonDown("Fire1")) // thn stigmh poy patietai to plhktro
        {
            Debug.Log("Fire!"); // me thn entolh afth grafei fire! sthn consola
        }


    }
}
