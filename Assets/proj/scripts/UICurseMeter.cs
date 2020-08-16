using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICurseMeter : MonoBehaviour
{

    public Text curseText;

    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       curseText.text = PlayerCurse.CurseMeter.ToString();
    }
}
