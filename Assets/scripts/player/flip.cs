using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{
public Animator anim;
 void Start(){
   anim = GetComponent<Animator>();
 }
 void Update()
 {
  if (Input.GetKey(KeyCode.D)) {anim.SetBool("flip",false);}
  else if (Input.GetKey(KeyCode.A)) {anim.SetBool("flip",true);}
  }
}
