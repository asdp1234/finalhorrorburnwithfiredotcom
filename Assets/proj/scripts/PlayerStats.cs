using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

       
    public static bool hasSword;

    public static bool hasKey;

    public static bool hasFlask;

    public static int curseMeter;


    // Start is called before the first frame update
    void Start()
    {
        curseMeter = 0;
    }

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
            if (hasSword)
                Debug.Log("yis kill them all");
        }
    }

    void smallBad()
    {
        curseMeter += 1;
    }

    void mediumBad()
    {
        curseMeter += 5;
    }

    void bigBad()
    {
        curseMeter += 10;
    }

}
