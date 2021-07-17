using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
  private float scale;
  private Transform player;
  private GameObject PlayerObject;
  public float max;
  public Gradient gradient;
  public GameObject ZeroPoint;

  void Start()
  {
    PlayerObject = GameObject.FindGameObjectWithTag("Player");
    player = PlayerObject.transform;
    gameObject.GetComponent<Renderer> ().material.color = gradient.Evaluate(1f);
  }

  void Update()
  {
    scale =  transform.localScale.x/10;
    scale*=0.046f;
    gameObject.transform.position = ZeroPoint.transform.position - new Vector3(scale,0,0);
  }



  public void SetHealth(float health){
    if (health>=0) {
      gameObject.transform.localScale = new Vector3(health/100,1,1);
      gameObject.GetComponent<Renderer> ().material.color = gradient.Evaluate(health/max);
    }
  }



}
