using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice : MonoBehaviour
{
    public GameObject triggerchoice;
    public GameObject canvis;
    public Button A, B;
    public PlayerStats;

    // Start is called before the first frame update
    void Start()
    {
        A.onClick.AddListener(ChoiceA);
        B.onClick.AddListener(ChoiceB);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            Debug.Log("a pressed");
            ChoiceA();
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            Debug.Log("b pressed");
            ChoiceB();
        }
    }

    void ChoiceA()
    {
        Debug.Log("you did good thing");
        Destroy(triggerchoice);
        Destroy(canvis);//change to hide
        Time.timeScale = 1;
    }
    void ChoiceB()
    {
        Debug.Log("you did wrilly bad thing");
        Destroy(triggerchoice);
        Destroy(canvis);
        Time.timeScale = 1;
    }

    if (getcurse())
	{

	}
}
