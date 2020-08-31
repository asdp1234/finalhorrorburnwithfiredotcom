using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivated : MonoBehaviour
{

    public GameObject Room;

    public Animator floorButtom;
    




    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag.Equals("Player"))
        {
            Debug.Log("watch this https://youtu.be/XCawU6BE8P8?t=114");
            EveryOneDies();


            floorButtom.SetBool("Pressed", false);

        }

    }

    private void EveryOneDies()
    {
        Destroy(Room);
    }

}
