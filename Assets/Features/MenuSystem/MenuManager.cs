using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
   public int gameScene;
   
   private void Start(){
      Cursor.visible = false;
      Cursor.lockState = CursorLockMode.Locked;
   }
   
}
