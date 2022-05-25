using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWallet : MonoBehaviour
{

    int gold;
    int food;
    int wood;
    int stone;
    int copper;
    int silver;
    [SerializeField]
    Text goldText;
    [SerializeField]
    Text foodText;
    [SerializeField]
    Text woodText;
    [SerializeField]
    Text stoneText;
    [SerializeField]
    Text copperText;
    [SerializeField]
    Text silverText;


    void Start()
    {
    }

    void Update()
    {
        goldText.text = "Gold: " + gold.ToString();
        foodText.text = food.ToString();
        woodText.text = wood.ToString();
        stoneText.text = stone.ToString();
        copperText.text = copper.ToString();
        silverText.text = silver.ToString();
    }
    public int Gold()
    {
        return gold;
    }
    public int Food()
    {
        return food;
    }
    public int Wood()
    {
        return wood;
    }
    public int Stone()
    {
        return stone;
    }
    public int Copper()
    {
        return copper;
    }
    public int Silver()
    {
        return silver;
    }

    public void ModifyGold(int _gold)
    {
        gold += _gold;
        gold = Mathf.Clamp(gold, 0, 5000);
    }
    public void ModifyFood(int _food)
    {
        food += _food;
        food = Mathf.Clamp(food, 0, 5000);
    }
    public void ModifyWood(int _wood)
    {
        wood += _wood;
        wood = Mathf.Clamp(wood, 0, 5000);
    }
    public void ModifyStone(int _stone)
    {
        stone += _stone;
        stone = Mathf.Clamp(stone, 0, 5000);
    }
    public void ModifyCopper(int _copper)
    {
        copper += _copper;
        copper = Mathf.Clamp(copper, 0, 5000);
    }
    public void ModifySilver(int _silver)
    {
        silver += _silver;
        silver = Mathf.Clamp(silver, 0, 5000);   
    }
}

