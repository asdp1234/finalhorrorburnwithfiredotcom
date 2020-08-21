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

   // public Animator animator;

    public GameObject sword;

    public int swingSpeed = 20;

    private bool isSwinging = false;

    public float swingTime = 1f;

    public float startSwing, endSwing;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        startSwing = 0f;
        
        endSwing = -180;
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

       // animator.SetFloat("Horizontal", move.x);
      //  animator.SetFloat("Vertical", move.y);
     //   animator.SetFloat("Speed", move.sqrMagnitude);

        if (Input.GetKeyDown("space"))
        {


            if (!isSwinging)
            {
                sword.SetActive(true);

                isSwinging = true;
            }
            
        }


       


        if (sword.transform.eulerAngles.z >= 90)
        {
            isSwinging = false;

            sword.transform.eulerAngles = new Vector3 (sword.transform.eulerAngles.x, sword.transform.eulerAngles.y, 0);

            sword.SetActive(false);

        }

        if (sword.transform.eulerAngles.z >= 45)
        {

        }

            if (isSwinging)
        {
            if (sword.transform.eulerAngles.z <= 45)
            {
                sword.transform.eulerAngles = new Vector3(sword.transform.eulerAngles.x, sword.transform.eulerAngles.y, sword.transform.eulerAngles.z + swingSpeed * 2);
            }
            
            if (sword.transform.eulerAngles.z >= 45)
            {
                sword.transform.eulerAngles = new Vector3(sword.transform.eulerAngles.x, sword.transform.eulerAngles.y, sword.transform.eulerAngles.z + swingSpeed);
            }

        }

    }

    

    
}
