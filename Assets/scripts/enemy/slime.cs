using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slime : MonoBehaviour
{
    public bool grounded;
    public bool canHit;
    public int atackDamage;
    public int tera;
    public float CheckRadius;
    public float atackRange;
    public float atackTime;
    public float AtackTimeCounter;
    public float dis;
    public float speed;
    public LayerMask groundLayer;
    public Transform groundCheck;
    public LayerMask playerLayer;
    public Rigidbody2D rb;
    private Transform player;
    private GameObject PlayerObject;


    void Start()
    {
       PlayerObject = GameObject.FindGameObjectWithTag("Player");
       player = PlayerObject.transform;
    }

    void Update()
    {
      if (AtackTimeCounter>=0) {
        AtackTimeCounter-=Time.deltaTime;
      }
      Vector2 target = new Vector2(player.position.x-tera,transform.position.y);
      dis = Vector2.Distance(target, transform.position);
      if (dis<=10) {
        transform.position = Vector2.MoveTowards(transform.position, target,speed * Time.deltaTime);
      }

      if (grounded) {
        rb.velocity=new Vector2(0,3);
      }
     if (canHit && AtackTimeCounter<=0) {
      player.GetComponent<health>().TakeDamage(atackDamage);
      AtackTimeCounter=atackTime;
     }


    }

    void FixedUpdate()
     {
       grounded = Physics2D.OverlapCircle(groundCheck.position,CheckRadius,groundLayer);
       canHit = Physics2D.OverlapCircle(transform.position,atackRange,playerLayer);
     }

     void OnDrawGizmosSelected()
     {
       if (transform==null) {
         return;
       }
       Gizmos.DrawWireSphere(transform.position,atackRange);
     }
}
