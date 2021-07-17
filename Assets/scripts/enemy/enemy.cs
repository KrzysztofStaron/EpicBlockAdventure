using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
  public int maxHealth=100;
  public int currentHealth=100;
  public Animator anim;
  public HealthBar bar;
  public Rigidbody2D rb;

    void Start()
    {
       currentHealth=maxHealth;
       bar.max=maxHealth;
    }

  public void TakeDamage(int damage){
     currentHealth-=damage;
     bar.SetHealth(currentHealth);
     anim.SetTrigger("hurt");
     if (currentHealth<=0) {
       Die();
     }
  }

  public void Knock(float strange){
    rb.velocity += new Vector2(strange,0);
  }


  void Die(){
    Debug.Log("Enemy Dead");
    Destroy(gameObject);
  }
}
