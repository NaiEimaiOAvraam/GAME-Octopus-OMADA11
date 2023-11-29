using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avatar_control : MonoBehaviour
{
    public float speed = 35f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
        transform.Translate(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
        if (transform.position.x > 90)
        {
            Vector3 v = transform.position;
            v.x = 90;
            transform.position = v;


        }
        if (transform.position.x < -95)
        {
            Vector3 v = transform.position;
            v.x = -95;
            transform.position = v;


        }
        if (transform.position.y > 50)
        {
            Vector3 v = transform.position;
            v.y = 50;
            transform.position = v;


        }
        if (transform.position.y < -40)
        {
            Vector3 v = transform.position;
            v.y = -40;
            transform.position = v;


        }
    }
}
