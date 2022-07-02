using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ResourceManager : MonoBehaviour
{
    public int gold { get; private set; }
    public int silver { get; private set; }
    public int copper { get; private set; }
    public int wood { get; private set; }
    public int food { get; private set; }
    public int stone { get; private set; }

    public UnityEvent<ResourceManager> OnGoldCollected;
    public UnityEvent<ResourceManager> OnSilverCollected;
    public UnityEvent<ResourceManager> OnCopperCollected;
    public UnityEvent<ResourceManager> OnWoodCollected;
    public UnityEvent<ResourceManager> OnFoodCollected;
    public UnityEvent<ResourceManager> OnStoneCollected;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "gold")
        {
            AddGold();
            other.gameObject.SetActive(false);
        }
        else if (other.tag == "silver")
        {
            AddSilver();
            other.gameObject.SetActive(false);
        }
        else if (other.tag == "copper")
        {
            AddCopper();
            other.gameObject.SetActive(false);
        }
        else if (other.tag == "wood")
        {
            AddWood();
            other.gameObject.SetActive(false);
        }
        else if (other.tag == "food")
        {
            AddFood();
            other.gameObject.SetActive(false);
        }
        else if (other.tag == "stone")
        {
            AddStone();
            other.gameObject.SetActive(false);
        }
    }

    public void AddGold()
    {
        gold += 20;
        Debug.Log("Gold = " + gold);
        OnGoldCollected.Invoke(this);
    }
    public void AddSilver()
    {
        silver += 50;
        OnSilverCollected.Invoke(this);
    }
    public void AddCopper()
    {
        copper += 70;
        OnCopperCollected.Invoke(this);
    }
    public void AddWood()
    {
        wood += 100;
        OnWoodCollected.Invoke(this);
    }
    public void AddFood()
    {
        food += 120;
        OnFoodCollected.Invoke(this);
    }
    public void AddStone()
    {
        stone += 150;
        OnStoneCollected.Invoke(this);
    }
}
