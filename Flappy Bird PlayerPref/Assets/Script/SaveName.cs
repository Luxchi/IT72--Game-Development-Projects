using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveName : MonoBehaviour
{
        public InputField NameInput;
        
        public void clickSave()
        {
            PlayerPrefs.SetString("NamePass", NameInput.text);
            SceneManager.LoadScene("FlappyBird");
        }
   
}
