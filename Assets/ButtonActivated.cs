using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivated : MonoBehaviour
{

    public GameObject Room;



    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag.Equals("Player"))
        {
            Debug.Log("watch this https://youtu.be/XCawU6BE8P8?t=114");
            EveryOneDies();
        }

    }

    private void EveryOneDies()
    {
        Destroy(Room);
    }

}
