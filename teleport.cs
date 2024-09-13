using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class teleport : MonoBehaviour
{
   public RawImage guiText;
    public int n_scene = 2;  

   void OnTriggerEnter(Collider col)  
   {
      if (col.tag.Equals("Player"))       
      {
         SceneManager.LoadScene(n_scene);
        guiText.enabled = true;

      }
   }
}
