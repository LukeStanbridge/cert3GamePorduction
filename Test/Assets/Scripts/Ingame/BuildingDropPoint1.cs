using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingDropPoint1 : MonoBehaviour
{
    public PlayerWallet wallet;
    public GameObject gameObject;

    private void Start()
    {
        gameObject.SetActive (false);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
