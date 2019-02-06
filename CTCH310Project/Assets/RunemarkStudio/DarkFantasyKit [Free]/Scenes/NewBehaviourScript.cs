using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
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

        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");

        if(v > 90)
        {
            transform.Rotate(90, h, 0);
        }

        else if (v < -90)
        {
            transform.Rotate(-90, h, 0);
        }

        else
        {
            transform.Rotate(-v, h, 0);
        }

    }
    }
