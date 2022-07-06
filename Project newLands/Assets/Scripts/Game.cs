using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public GameObject buildingUI;
    // Start is called before the first frame update
    void Start()
    {
        buildingUI.SetActive(false);
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            print("Building");
            Cursor.lockState = CursorLockMode.Confined;
            buildingUI.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider clloider)
    {
        Cursor.lockState = CursorLockMode.Locked;
        buildingUI.SetActive(false);
        // Update is called once per frame

    }
    public void main()
    {
        //loadingScreen.gameObject.SetActive(true);
         SceneManager.LoadScene("Mainmenu");
    }
    void Update()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }
}
