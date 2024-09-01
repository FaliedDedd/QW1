using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class teleport : MonoBehaviour
{
   public RawImage guiText;
    public int n_scene = 2;  // индекс загружаемой сцены по умолчанию, который в редакторе можно изменить

   void OnTriggerEnter(Collider col)  // вход в коллайдер-триггер объекта-двери или телепорта
   {
      if (col.tag.Equals("Player"))        // если это объект с тегом "Player"
      {
         SceneManager.LoadScene(n_scene);  // загружаем сцену с заданным индексомS
        guiText.enabled = true;

      }
   }
}
