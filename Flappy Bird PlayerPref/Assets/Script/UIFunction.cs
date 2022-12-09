using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIFunction : MonoBehaviour
{
   public void BacktoStart(){
    SceneManager.LoadScene("Amenu");
  }

  public void QuitGame()
{   
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
    Application.Quit();
}
}
