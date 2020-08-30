using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golemAI : MonoBehaviour
{
    bool idelstate = false;
    [SerializeField]
    Transform point1, point2;
    [SerializeField]
    float speed = 3;
    bool left = false;
    Playercontroller2d player;
    [SerializeField]
    float health = 2;
    // Update is called once per frame

    private bool throwing = false;

    public Animator animator;

    Vector2 playerpos;

    public GameObject go,holder;

    float ntime = 3,ctime,nhittime = .3f,chittime;


    public GameObject Explosions;

    public PlayerStats ps;

    private void Start()
    {
        holder = GameObject.FindGameObjectWithTag("Player");
        player = holder.GetComponent<Playercontroller2d>();
        ps = holder.GetComponent<PlayerStats>();
       
    }

    void ThrowTheRock()
    {
        Instantiate(go, this.transform);
    }


    void Update()
    {
        ctime += Time.deltaTime;
        chittime += Time.deltaTime;

        if (Vector3.Distance(transform.position, player.transform.position) < 100.05f)
        {
            if (ctime >= ntime)
            {
                
                StartCoroutine(WaitForThrow());
                ctime = 0;
            }

        }

      
        if (health <= 0)
        {
            Destroy(this.transform.parent.gameObject);
        }


        if (!idelstate)
        {

            if (Vector3.Distance(transform.position, point2.position) < 0.001f)
            {
                left = true;
            }
            if (Vector3.Distance(transform.position, point1.position) < 0.001f)
            {
                left = false;
            }
            if (left)
            {
                transform.position = Vector3.MoveTowards(transform.position, point1.position, speed * Time.deltaTime);
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, point2.position, speed * Time.deltaTime);
            }
        }
        else
        {

        }
    }

    IEnumerator WaitForThrow()
    {

        animator.SetBool("Throwing", true);

        idelstate = true;
        
        yield return new WaitForSeconds(0.5f);

        animator.SetBool("Throwing", false);

        idelstate = false;

        ThrowTheRock();

    }


    private void OnDestroy()
    {
        GameObject effectinstance = (GameObject)Instantiate(Explosions, transform.position, transform.rotation);
        ps.bigBad();
        Destroy(effectinstance, 5f);
    }

    public void DamageHp()
    {
        if (chittime >= nhittime)
        {

            health--;
           
            chittime = 0;
        }
    }
}
        
        

