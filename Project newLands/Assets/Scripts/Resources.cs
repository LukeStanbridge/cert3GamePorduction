using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resources : MonoBehaviour
{
    public wallet wallet;
    public GameObject BuildingUI;
    public int MaxAmount = 100;
    public int currentAmount = 100;
  
    // Start is called before the first frame update
    void Start()
    {
         BuildingUI.SetActive(false);
        if(wallet == null)
        {
            wallet = GetComponent<wallet>();
        }
    }


    public void giveFood(int amount)
    {
       if (amount < currentAmount)
       {
           currentAmount -= amount;
           wallet.ModifyFood(amount);
       }
       else
       {
            if (currentAmount > 0)
            {
                wallet.ModifyFood(currentAmount);
            }
            ResourceNodeDepleted();
       }
    }
    public void giveStone(int amount)
    {
        if (amount < currentAmount)
        {
            //giveamount
            currentAmount -= amount;
            wallet.ModifyStone(amount);
        }
        else
        {
            //dont give amount
            if (currentAmount > 0)
            {
                wallet.ModifyStone(currentAmount);
            }
            ResourceNodeDepleted();
        }

    }
    public void giveCopper(int amount)
    {
        if (amount < currentAmount)
        {
            //giveamount
            currentAmount -= amount;
            wallet.ModifyCopper(amount);
        }
        else
        {
            //dont give amount
            if (currentAmount > 0)
            {
                wallet.ModifyCopper(currentAmount);
            }
            ResourceNodeDepleted();
        }

    }
    public void giveSilver(int amount)
    {
        if (amount < currentAmount)
        {
            //giveamount
            currentAmount -= amount;
            wallet.ModifySilver(amount);
        }
        else
        {
            //dont give amount
            if (currentAmount > 0)
            {
                wallet.ModifySilver(currentAmount);
            }
            ResourceNodeDepleted();

        }

    }

    public void ResourceNodeDepleted()
    {
        gameObject.SetActive(false);
        BuildingUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        //start respawn function/timer
    }

    private void OnTriggerEnter(Collider collider)
    {
       if(collider.gameObject.tag == "Player")
       {
            print("Building");
            Cursor.lockState = CursorLockMode.Confined;
            BuildingUI.SetActive(true);
       }
    }
    private void OnTriggerExit(Collider clloider)
    {
        Cursor.lockState = CursorLockMode.Locked;
        BuildingUI.SetActive(false);
    }
}
