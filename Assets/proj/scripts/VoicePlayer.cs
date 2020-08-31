using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoicePlayer : MonoBehaviour
{

    private int Rando;

    public GameObject Voice1;
    public GameObject Voice3;
    public GameObject Voice2;



    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag.Equals("Player"))
        {
           Rando = UnityEngine.Random.Range(0,5);

            RollTheDice();

            Destroy(this);
        }

    }

private void RollTheDice()
    {
        if(Rando == 1)
        {
            Voice1.SetActive(true);
                
        }
        if (Rando == 2)
        {
            Voice2.SetActive(true);
        }
        if (Rando == 3)
        {
            Voice3.SetActive(true);
        }
    }



}
