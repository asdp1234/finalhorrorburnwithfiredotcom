using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golemAI : MonoBehaviour
{
    bool idelstate = false;
    [SerializeField]
    Transform point1, point2;
    [SerializeField]
    float speed  = 3;
    bool left = false;
    // Update is called once per frame
    void Update()
    {
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
