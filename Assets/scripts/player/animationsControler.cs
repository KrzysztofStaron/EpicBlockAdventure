using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationsControler : MonoBehaviour
{
    public Animator anim;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float CheckRadius;
    public bool grounded;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
      grounded = Physics2D.OverlapCircle(groundCheck.position,CheckRadius,groundLayer);
      anim.SetBool("grounded",grounded);
    }

    void Update()
    {
      if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A)) {
        anim.SetBool("runing",true);
      }else{anim.SetBool("runing",false);}
    }

}
