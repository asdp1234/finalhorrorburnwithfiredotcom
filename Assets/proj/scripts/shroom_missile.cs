using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shroom_missile : ObjectCompendium
{
    [SerializeField]
    Rigidbody2D rb;

    GameObject go;

    Playercontroller2d player;

    [SerializeField]
    float speed;
    [SerializeField]
    Vector2 temp,playerpos;

    // Start is called before the first frame update
    void Start()
    {
        go = GameObject.FindGameObjectWithTag("Player");
        player = go.GetComponent<Playercontroller2d>();

        playerpos = player.transform.position;


    }

    // Update is called once per frame
    void Update()
    {

        //rb.rotation += -165.0f * Time.unscaledDeltaTime;

        

        transform.position = Vector2.MoveTowards(transform.position, playerpos, (speed * Time.deltaTime));
        if (Vector3.Distance(transform.position, playerpos) < 0.001f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            Debug.Log("owch");
            Destroy(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
