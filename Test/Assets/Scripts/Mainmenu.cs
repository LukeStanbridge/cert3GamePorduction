using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void LoadMapLand()
    {
        SceneManager.LoadScene("NewLands");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
