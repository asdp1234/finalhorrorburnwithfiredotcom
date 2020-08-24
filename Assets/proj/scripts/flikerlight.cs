using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;
public class flikerlight : MonoBehaviour
{
    // Start is called before the first frame update
    public Light2D lantern;
    float startinten = 1.10f,topinten = 1.2f;
    float neededtime = .75f, currenttime;
    bool tickup;

    void Start()
    {
        lantern.pointLightOuterRadius = startinten; 
    }

    private void Update()
    {
        currenttime += Time.deltaTime;
        if (currenttime >= neededtime)
        {
            currenttime = 0;
            
            if (lantern.pointLightOuterRadius >= topinten)
            {
                tickup = false;
            }
            if (lantern.pointLightOuterRadius <= startinten)
            {
                tickup = true;
            }
            if (tickup)
            {
                lantern.pointLightOuterRadius += 0.0625f;
            }
            else
            {
                lantern.pointLightOuterRadius -= 0.0625f;
            }
        }
    }

}
