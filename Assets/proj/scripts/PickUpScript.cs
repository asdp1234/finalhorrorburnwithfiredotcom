using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public PlayerStats player;
    public bool  Sword;
    public bool  Key;
    public bool  Flask;

    private void Start()
    {
        player = FindObjectOfType<PlayerStats>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag.Equals("Player"))
        {
            if (Sword)
                Debug.Log("The player has the sword, no one is safe");
            //PlayerStats.hasSword = true;
            player.Setsword(true);
            Destroy(gameObject);

            if (Key)
            {
                Debug.Log("I got the key, I got the secret");
            }

            if (Flask)
                Debug.Log("Ladies and gentlemen, we got him");
        }
        
    }

    
}
