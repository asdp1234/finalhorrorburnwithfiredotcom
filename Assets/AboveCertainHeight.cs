using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboveCertainHeight : MonoBehaviour
{

    public SpriteRenderer sRender;

    public GameObject playerPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerPos.transform.position.y >= 45.31503)
        {
            sRender.sortingOrder = 3;
        }
        else
        {
            sRender.sortingOrder = 4;
        }



    }
}
