using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ogre : MonoBehaviour
{

    public int intel = 5;
    public bool getSmart = false;
    public bool getDumb = false;

    void Greet()
    {
        if (getSmart == true && intel <6)
        {
            intel = intel + 1;
        }
        
        if (getDumb == true && intel > 0)
        {
            intel = intel - 1;
        }

        switch (intel)
        {
            case 5:
                print("Hello, good sir! Do you like physics?");
                break;

            case 4:
                print("Ello, guv!");
                break;

            case 3:
                print("What you want?");
                break;

            case 2:
                print("Ugh ugh...me want food");
                break;

            case 1:
                print("Grrrr *fart*");
                break;

            default:
                print("*drools*");
                break;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        Greet();

    }

    // Update is called once per frame
    void Update()
    {
        Check();

        getDumb = false;
        getSmart = false;
    }

    void Check()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            getSmart = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            getDumb = true;
        }

        if (getSmart == true || getDumb == true)
        {
            Greet();
        }
    }
}
