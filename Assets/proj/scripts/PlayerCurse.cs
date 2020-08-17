using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCurse : MonoBehaviour
{
    public static int CurseMeter;


    void Start()
    {

        CurseMeter = 5;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            smallBad();
        }
        if (Input.GetKeyDown("g"))
        {
            mediumBad();
        }
        if (Input.GetKeyDown("h"))
        {
            bigBad();
        }
    }

    void smallBad()
    {
        CurseMeter += 1;
    }

    void mediumBad()
    {
        CurseMeter += 5;
    } 

    void bigBad()
    {
        CurseMeter += 10;
    }

}
