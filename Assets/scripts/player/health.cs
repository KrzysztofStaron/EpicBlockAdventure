using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public float maxHp;
    public float currentHp;
    public HealthBar bar;
    void Start()
    {
      currentHp=maxHp;
      bar.max=maxHp;
    }

    public void TakeDamage(int dmg)
    {
      currentHp-=dmg;
    }

    void Update()
    {
      if (currentHp<=0) {
        Debug.Log("umarles");
        bar.SetHealth(currentHp);
      }else{
        bar.SetHealth(currentHp);
      }

    }
}
