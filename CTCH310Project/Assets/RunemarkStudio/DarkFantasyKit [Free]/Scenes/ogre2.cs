﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ogre2 : MonoBehaviour
{




    public int intel = 5;

    float test()
    {
        return 5.0f;
    }

    void Greet()
    {

        switch (intel)
        {

            case 5:
                print("Hello, good sir! Do you like physics?");
                break;

            case 4:
                print("Ello, guv!");
                break;

            case 3:
                print("What you want?!");
                break;

            case 2:
                print("Ugh ugh... me want food.");
                break;
            case 1:
                print("Grrrrrr *fart*");
                break;

            default:
                print(" ... stares at you blankly");
                break;
        }


    }


    // Use this for initialization
    void Start()
    {

        Greet();
        float testNum = test();
        print(testNum);

    }

}