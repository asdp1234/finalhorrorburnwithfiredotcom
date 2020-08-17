using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{

    public bool  Sword;
    public bool  Key;
    public bool  Flask;



    private void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag.Equals("player"))
        {
            if (Sword)
                Debug.Log("The player has the sword, no one is safe");

            if (Key)
            {
                Debug.Log("I got the key, I got the secret");
            }

            if (Flask)
                Debug.Log("Ladies and gentlemen, we got him");
        }

    }
}
