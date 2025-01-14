using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CharacterControllerScript : MonoBehaviour
{
    private float speed;

    void Start()
    {
        speed = 1.0f;
    }

    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    transform.position += transform.up * speed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.position -= transform.up * speed * Time.deltaTime;
        //}
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
    }
}