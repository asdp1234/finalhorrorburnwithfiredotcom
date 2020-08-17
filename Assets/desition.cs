using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desition : MonoBehaviour
{

    listofchoices list;
    
    // Start is called before the first frame update
    void Start()
    {
        list = FindObjectOfType<listofchoices>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag.Equals("Player"))
        {
            if (this.tag.Equals("One"))
            {
                Debug.Log("eyes");
                list.Getlist(0).SetActive(true);
                Time.timeScale = 0;
            }
            if (this.tag.Equals("Two"))
            {
                Debug.Log("red");
            }
        }
        
    }
}
