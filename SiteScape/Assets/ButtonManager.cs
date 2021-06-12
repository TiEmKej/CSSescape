using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public void CloseApp(){
        Application.Quit();
    }
    public void StartGame(){
        SceneManager.LoadScene("TestPlay");
    }
    public void OptionScreen(){
        
    }
}
