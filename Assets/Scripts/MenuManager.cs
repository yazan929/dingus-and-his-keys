using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{   
    public GameObject settingsPage;
    
    public GameObject howToPlayPage;
    public GameObject mainPage;
    public void SettingsClicked(){

        mainPage.SetActive(false);
        settingsPage.SetActive(true);
    }
    public void howToPlayClicked(){

        mainPage.SetActive(false);
        howToPlayPage.SetActive(true);
    }
    public void BackToMainClicked(){

        mainPage.SetActive(true);
        settingsPage.SetActive(false);
        howToPlayPage.SetActive(false);

    }


    public void ExitGame(){
        Application.Quit();
    }

    public void PlayEasy(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

}
