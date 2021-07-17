using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeinMenu : MonoBehaviour
{
  public GameObject Options;
  public GameObject Game;

   public void PlayGame(){
     SceneManager.LoadScene("World");
   }

   public void Quit(){
     Debug.Log("Quit");
     Application.Quit();
   }

   public void ChangeMenu(){
       Options.SetActive(true);
       Game.SetActive(false);
   }

   public void Back(){
       Options.SetActive(false);
       Game.SetActive(true);
   }
}
