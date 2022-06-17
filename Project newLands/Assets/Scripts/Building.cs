using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    //UI
    public wallet wallet;
    public GameObject buildingUI;
    public GameObject nobleButton;
    public GameObject tavernButton;
    public GameObject manerButton;
    public GameObject workShopButton;
    public GameObject blacksmithButton;
    public GameObject treasuryButton;
    public GameObject fortButton;

    //Buildings
    public GameObject woodBuild;
    public GameObject stoneBuild;
    public GameObject copperBuild;
    public GameObject silverBuild;
    //Houses
    public GameObject nobleBuild;
    public GameObject tavernBuild;
    public GameObject fortBuild;
    public GameObject destroyedfortBuild;
    // Start is called before the first frame update
    void Start()
    {
        buildingUI.SetActive(false);
        woodBuild.SetActive(false);
        stoneBuild.SetActive(false);
        copperBuild.SetActive(false);
        silverBuild.SetActive(false);
        tavernBuild.SetActive(false);
        fortBuild.SetActive(false);
        destroyedfortBuild.SetActive(true);
        nobleBuild.SetActive(false);
        //UI
        nobleButton.SetActive(true);
        tavernButton.SetActive(true);
        manerButton.SetActive(true);
        workShopButton.SetActive(true);
        blacksmithButton.SetActive(true);   
        treasuryButton.SetActive(true);
        fortButton.SetActive(true);
        if (wallet == null)
        {
            wallet = GetComponent<wallet>();
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
       if(collider.gameObject.tag == "Player")
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
    }
    public void BuyFort(int amount)
    {
        if (amount < wallet.gold)
        {
            fortBuild.SetActive(true);
            fortButton.SetActive(false);
            wallet.ModifyGold(-amount);
        }
        else
        {
            //dont give Building
        }
        
    }
    public void BuyWoodHouse(int amount)
    {
        if (amount < wallet.gold)
        {
            woodBuild.SetActive(true);
            manerButton.SetActive(false);
            wallet.ModifyGold(-amount);
        }
        else
        {
            //dont give Building
        }
    }
    public void BuyStoneHouse(int amount)
    {
        if (amount < wallet.gold)
        {
            stoneBuild.SetActive(true);
            workShopButton.SetActive(false);
            wallet.ModifyGold(-amount);
        }
        else
        {
            //dont give Building
        }
        
    }
    public void BuyCopperHouse(int amount)
    {
        if (amount < wallet.gold)
        {
            copperBuild.SetActive(true);
            blacksmithButton.SetActive(false);
            wallet.ModifyGold(-amount);
        }
        else
        {
            //dont give Building
        }
        
    }
    public void BuySilverHouse(int amount)
    {
        if (amount < wallet.gold)
        {
            silverBuild.SetActive(true);
            treasuryButton.SetActive(false);
            wallet.ModifyGold(-amount);
        }
        else
        {
            //dont give Building
        }
    }
    public void BuyTavernHouse(int amount)
    {
        if (amount < wallet.gold)
        {
            tavernBuild.SetActive(true);
            tavernButton.SetActive(false);
            wallet.ModifyGold(-amount);
        }
        else
        {
            //dont give Building
        }
    }
    public void BuyNobleHut(int amount)
    {
        if (amount < wallet.gold)
        {
            nobleBuild.SetActive(true);
            nobleButton.SetActive(false);
            wallet.ModifyGold(-amount);
        }
        else
        {
            //dont give Building
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
