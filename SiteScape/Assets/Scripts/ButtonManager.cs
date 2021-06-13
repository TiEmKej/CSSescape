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
        SceneManager.LoadScene("Level 1");
    }
    public void HowToPlayScreen(){
        SceneManager.LoadScene("Info");
    }
    public void LoadMenu(){
        SceneManager.LoadScene("MainMenu");
    }
    public void LoadNextLevel(){
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene+1);
    }
}
