using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPostion : MonoBehaviour
{
      private GameObject PlayerObject;
    void Start()
    {
            PlayerObject = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
      transform.position = new Vector3(PlayerObject.transform.position.x-4.81f,PlayerObject.transform.position.y+6.8f,0);
    }
}
/*
⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛
⬛⬜⬜⬜⬜⬛⬜⬜⬜⬛⬛
⬛⬛⬛⬛⬜⬛⬜⬛⬛⬜⬛
⬛⬛⬛⬛⬜⬛⬜⬛⬛⬜⬛
⬛⬛⬛⬛⬜⬛⬜⬛⬛⬜⬛
⬛⬛⬛⬛⬜⬛⬜⬛⬛⬜⬛
⬛⬛⬛⬛⬜⬛⬜⬛⬛⬜⬛
⬛⬜⬜⬜⬛⬛⬜⬜⬜⬛⬛
⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛
*/
