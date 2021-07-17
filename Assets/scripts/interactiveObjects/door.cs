using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
  public bool touch;
  public float CheckRadius;
  public GameObject Eimage;
  public LayerMask playerLayer;
  public Animator anim;


    void Update()
    {
      if (touch) {
        Eimage.SetActive(true);
      }else {
        Eimage.SetActive(false);
      }
    }

    void FixedUpdate()
     {
       touch = Physics2D.OverlapCircle(gameObject.transform.position,CheckRadius,playerLayer);
       anim.SetBool("touch",touch);
     }
}
