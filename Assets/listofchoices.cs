using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listofchoices : MonoBehaviour
{
    [SerializeField]
    GameObject[] list;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject Getlist(int i)
    {
        return list[i];
    }
}
