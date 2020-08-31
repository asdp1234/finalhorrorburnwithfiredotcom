using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField]
    Button play,help,quit,back;
    [SerializeField]
    Text txt;

    // Start is called before the first frame update
    void Start()
    {
        play.onClick.AddListener(Play);
        help.onClick.AddListener(Help);
        back.onClick.AddListener(Back);
        quit.onClick.AddListener(Quit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void Play()
    {
        SceneManager.LoadScene("map");
    }
    void Help()
    {
        txt.gameObject.SetActive(true);
    }
    void Back()
    {
        txt.gameObject.SetActive(false);
    }
    void Quit()
    {
        Application.Quit();
    }

}
