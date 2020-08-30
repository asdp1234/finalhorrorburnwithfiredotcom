using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    [SerializeField]   
    bool hasSword;
    [SerializeField]
    bool hasKey;
    [SerializeField]
    bool hasFlask;

    public static int curseMeter, runeCount;


    // Start is called before the first frame update
    void Start()
    {
        curseMeter = 99;
        
    }

    void Update()
    {
        Debug.Log(curseMeter);

    }

    void smallBad()
    {
        curseMeter += 1;
    }

    void mediumBad()
    {
        curseMeter += 5;
    }

    public void bigBad()
    {
        curseMeter += 10;
    }

    public void Setsword(bool set)
    {
        hasSword = set;
    }
    public void Setkey(bool set)
    {
        hasKey = set;
    }
    public void Setflask(bool set)
    {
        hasFlask = set;
    }
    public int getcurse()
    {
        return curseMeter;
    }

}
