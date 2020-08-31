using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public PlayerStats player;
    public bool  Rune;
   

    private void Start()
    {
        player = FindObjectOfType<PlayerStats>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag.Equals("Player"))
        {
            if (Rune)
            {
                
                Destroy(gameObject);

                PlayerStats.runeCount ++;
            }

            
        }
        
    }

    
}
