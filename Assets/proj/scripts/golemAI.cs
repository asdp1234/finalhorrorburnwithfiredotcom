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
            float step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, point2.position, step);
            if (Vector3.Distance(transform.position, point2.position) < 0.001f)
            {
                left = true;
                //transform.position = Vector3.MoveTowards(transform.position, point1.position, step);
            }
            if (Vector3.Distance(transform.position, point1.position) < 0.001f)
            {
                left = false;
                //transform.position = Vector3.MoveTowards(transform.position, point1.position, step);
            }
        }
        else
        {

        }
    }
}
