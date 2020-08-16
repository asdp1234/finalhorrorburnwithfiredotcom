using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller2d : MonoBehaviour
{
    [SerializeField]
    float speed = 5;
    [SerializeField]
    Rigidbody2D rb;
    [SerializeField]
    Vector2 move = new Vector2(0, 0);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");

        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
    }

    void Update()
    {
        
    }
}
