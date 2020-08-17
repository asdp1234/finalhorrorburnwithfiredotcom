using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listofchoices : MonoBehaviour
{
    [SerializeField]
    GameObject[] list;
    // Start is called before the first frame update
  
    public GameObject Getlist(int i)
    {
        return list[i];
    }
}
