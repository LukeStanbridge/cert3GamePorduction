using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Manager : MonoBehaviour
{
    //public GameObject loadingScreen;

    public void Start()
    {
 
    }
    
    //level
    public void PlayEasyMap()
    {
        //loadingScreen.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

   
    //GameManager
    public void QuitGame()
    {
        Application.Quit();
    }

    public void main()
    {
        //loadingScreen.gameObject.SetActive(true);
        SceneManager.LoadScene("Mainmenu");
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
}
