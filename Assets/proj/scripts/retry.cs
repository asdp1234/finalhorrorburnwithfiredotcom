using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class retry : MonoBehaviour
{
    public Button rtry;
    public Button rtry1;

    // Start is called before the first frame update
    void Start()
    {
        rtry.onClick.AddListener(restart);
        rtry1.onClick.AddListener(restart);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void restart()
    {
        SceneManager.LoadScene("map");
    }
}
