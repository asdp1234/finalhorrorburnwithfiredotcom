using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice : MonoBehaviour
{
    public GameObject triggerchoice,go;
    public GameObject canvis;
    public Button A, B;
    public PlayerStats player;

    public GameObject White;

    public GameObject Black;

    // Start is called before the first frame update
    void Start()
    {
        go = GameObject.FindGameObjectWithTag("Player");
        A.onClick.AddListener(ChoiceA);
        B.onClick.AddListener(ChoiceB);
        player = go.GetComponent<PlayerStats>();
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
        if (player.getcurse() > 50)
        {
            B.GetComponent<Image>().color = new Color32(77, 77, 77, 100);
            B.GetComponent<Button>().enabled = false;
        }
    }

    void ChoiceA()
    {
        Debug.Log("you did good thing");
        Destroy(triggerchoice);
        Destroy(canvis);//change to hide
        Time.timeScale = 1;


        White.SetActive(true);
    }
    void ChoiceB()
    {
        Debug.Log("you did wrilly bad thing");
        Destroy(triggerchoice);
        Destroy(canvis);
        Time.timeScale = 1;

        Black.SetActive(true);
    }

  
}
