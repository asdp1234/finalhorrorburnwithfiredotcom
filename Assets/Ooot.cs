using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ooot : MonoBehaviour
{
    

    public GameObject zero, one, two, three, four;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
            if (PlayerStats.runeCount == 0)
            {
                zero.SetActive(true);
            }
            else {
                zero.SetActive(false);
                    }
        if (PlayerStats.runeCount == 1)
            {
                one.SetActive(true);
            }
            else {
                one.SetActive(false);
                    }
        if (PlayerStats.runeCount == 2)
            {
                two.SetActive(true);
            }
            else {
                two.SetActive(false);
                    }
        if (PlayerStats.runeCount == 3)
            {
                three.SetActive(true);
            }
            else {
                three.SetActive(false);
                    }
        if (PlayerStats.runeCount == 4)
            {
                four.SetActive(true);
            }
            else {
                four.SetActive(false);
                    }
       


    }
}
