using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole : MonoBehaviour
{

    public GameObject respawn,go;
    Playercontroller2d player;
   
    // Start is called before the first frame update
    void Start()
    {
        respawn = GameObject.FindGameObjectWithTag("rspawn");
        go = GameObject.FindGameObjectWithTag("Player");
        player = go.GetComponent<Playercontroller2d>();

        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.transform.position = new Vector2(0,0);
            other.gameObject.GetComponent<Playercontroller2d>().Damagehealth();
        }

    }
}
