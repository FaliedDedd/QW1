using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scenem : MonoBehaviour
{
	public RawImage guiText;
	
  public void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        guiText.enabled = true;
    }
    
    public void ApplicationQuit()
      {
         Application.Quit();    
      }
}
