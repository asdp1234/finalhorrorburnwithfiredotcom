﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golemAI : MonoBehaviour
{
    bool idelstate = false;
    [SerializeField]
    Transform point1, point2;
    [SerializeField]
    float speed = 3;
    bool left = false;
    Playercontroller2d player;
    // Update is called once per frame

    Vector2 playerpos;

    public GameObject go,holder;

    float ntime = 3,ctime;

    private void Start()
    {
        holder = GameObject.FindGameObjectWithTag("Player");
        player = holder.GetComponent<Playercontroller2d>();

       
    }



    void Update()
    {
        ctime += Time.deltaTime;
        Debug.Log(Vector3.Distance(transform.position, player.transform.position));

        if (Vector3.Distance(transform.position, player.transform.position) < 100.05f)
        {
            if (ctime >= ntime)
            {
             Instantiate(go,this.transform);
                ctime = 0;
            }

        }



        if (!idelstate)
        {

            if (Vector3.Distance(transform.position, point2.position) < 0.001f)
            {
                left = true;
            }
            if (Vector3.Distance(transform.position, point1.position) < 0.001f)
            {
                left = false;
            }
            if (left)
            {
                transform.position = Vector3.MoveTowards(transform.position, point1.position, speed * Time.deltaTime);
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, point2.position, speed * Time.deltaTime);
            }
        }
        else
        {

        }
    }

}
        
        

