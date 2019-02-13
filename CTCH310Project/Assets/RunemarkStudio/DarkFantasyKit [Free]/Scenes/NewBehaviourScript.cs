using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {

        Cursor.lockState = CursorLockMode.Locked;

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, 0.1f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -0.1f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0f, 0f);
        }

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        if(Input.GetAxis("Mouse Y") > 90.0f)
        {
            transform.eulerAngles = new Vector3(90.0f, yaw, 0.0f);
        }

         else if(Input.GetAxis("Mouse Y") < -90.0f)
        {
            transform.eulerAngles = new Vector3(-90.0f, yaw, 0.0f);

        }
        else
        {
            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        }
        //transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        // First try at moving camera with mouse

        // float h = Input.GetAxis("Mouse X");
        //float v = Input.GetAxis("Mouse Y");

        //   transform.Rotate(90, h, 0);
         //   transform.Rotate(-90, h, 0);

    }
    }
