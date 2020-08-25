using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller2d : MonoBehaviour
{
    [SerializeField]
    float speed = 1;
    [SerializeField]
    Rigidbody2D rb;
    [SerializeField]
    Vector2 move = new Vector2(0, 0);

    public Animator animator;

    public GameObject sword;

    public int swingSpeed = 20;

    private bool isSwinging = false;

    public float swingTime = 1f;

    public float startSwing, endSwing;

    public float directionSwing;

    public bool facingRightSwing, facingLeftSwing;

    public bool direction;

    public GameObject graphics;

    private bool greater = false;
    

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

      if (move.sqrMagnitude <= 0.01)
        {
            animator.SetBool("IsMoving", false);
        }
      else
        {
            animator.SetBool("IsMoving", true);
        }
      


        if (move.x <= -0.01)
        {
            graphics.transform.localScale = new Vector3(-1, graphics.transform.localScale.y, graphics.transform.localScale.z);

            direction = true;
        }

        if (move.x >= 0.01)
        {
            graphics.transform.localScale = new Vector3(1, graphics.transform.localScale.y, graphics.transform.localScale.z);
            direction = false;
        }


        if (Input.GetKeyDown("space"))
        {


            if (!isSwinging)
            {
               

                isSwinging = true;

                if (direction)
                {
                    Swingleft();
                }

                if (!direction)
                {
                    Swingright();
                }

               
            }
            
        }



        if (facingRightSwing)
        {
            if (sword.transform.eulerAngles.z >= 225)
            {
                isSwinging = false;             

                sword.transform.eulerAngles = new Vector3(sword.transform.eulerAngles.x, sword.transform.eulerAngles.y, 135);

                sword.SetActive(false);

                facingRightSwing = false;

            }

        }

        if (facingLeftSwing)
        {
            if (sword.transform.eulerAngles.z <= 1)

            {
                greater = true;
            }

            if (greater)
            {
                if (sword.transform.eulerAngles.z >= 35)
                {
                    isSwinging = false;

                    sword.transform.eulerAngles = new Vector3(sword.transform.eulerAngles.x, sword.transform.eulerAngles.y, -35);

                    sword.SetActive(false);

                    facingLeftSwing = false;

                    greater = false;

                }
            }
        }

        if (isSwinging)
        {

            if (facingRightSwing)
            {

                if (sword.transform.eulerAngles.z <= 180)
                {
                    sword.transform.eulerAngles = new Vector3(sword.transform.eulerAngles.x, sword.transform.eulerAngles.y, sword.transform.eulerAngles.z + swingSpeed * 2);
                }

                if (sword.transform.eulerAngles.z >= 180)
                {
                    sword.transform.eulerAngles = new Vector3(sword.transform.eulerAngles.x, sword.transform.eulerAngles.y, sword.transform.eulerAngles.z + swingSpeed);
                }
            }
            if (facingLeftSwing)
            {

                if (sword.transform.eulerAngles.z <= 0)
                {
                    sword.transform.eulerAngles = new Vector3(sword.transform.eulerAngles.x, sword.transform.eulerAngles.y, sword.transform.eulerAngles.z + swingSpeed * 2);
                }

                if (sword.transform.eulerAngles.z >= 0  )
                {
                    sword.transform.eulerAngles = new Vector3(sword.transform.eulerAngles.x, sword.transform.eulerAngles.y, sword.transform.eulerAngles.z + swingSpeed);
                }
            }
        }

    }

    void Swingleft()
    {

        sword.transform.eulerAngles = new Vector3(sword.transform.eulerAngles.x, sword.transform.eulerAngles.y, -35);

        sword.SetActive(true);

        facingLeftSwing = true;

            

    }

    void Swingright()
    {

        sword.transform.eulerAngles = new Vector3(sword.transform.eulerAngles.x, sword.transform.eulerAngles.y, 135);

        sword.SetActive(true);

        facingRightSwing = true;


    }





}
