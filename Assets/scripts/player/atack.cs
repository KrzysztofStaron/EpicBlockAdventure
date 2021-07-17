using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atack : MonoBehaviour
{
    public Animator anim;
    public float AtackTime;
    public float atackRange;
    public Transform atackPoint;
    public LayerMask enemyLayer;
    private float AtackTimeCounter;
    public int atackDamage;
    private Transform player;
    private GameObject PlayerObject;
    void Start()
    {
     anim = GetComponent<Animator>();
     PlayerObject = GameObject.FindGameObjectWithTag("Player");
     player = PlayerObject.transform;
    }

    void Update()
    {
      if (Input.GetMouseButtonDown(0) && AtackTimeCounter<=0) {
        Atack();
      }
      if (AtackTimeCounter>=0) {
        AtackTimeCounter-=Time.deltaTime;
      }
    }

    void Atack()
    {
      AtackTimeCounter=AtackTime;
      anim.SetTrigger("atack");
      Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(atackPoint.position,atackRange,enemyLayer);
      foreach (Collider2D enemy in hitEnemies) {
          enemy.GetComponent<enemy>().TakeDamage(atackDamage);
          enemy.GetComponent<enemy>().Knock(player.transform.localScale.x*2.5f);
     }
    }

    void OnDrawGizmosSelected()
    {
      if (atackPoint==null) {
        return;
      }
      Gizmos.DrawWireSphere(atackPoint.position,atackRange);
    }
  }
