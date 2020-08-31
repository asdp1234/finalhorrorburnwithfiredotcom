using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole : MonoBehaviour
{

    public GameObject respawn;

    Playercontroller2d player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Playercontroller2d>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.position = respawn.transform.position;
           player.Damagehealth();
        }

    }
}
