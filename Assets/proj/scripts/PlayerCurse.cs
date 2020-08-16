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
            CurseMeter += 10;
        }
    }
}
