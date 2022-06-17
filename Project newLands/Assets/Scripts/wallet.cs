using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class wallet : MonoBehaviour
{
    public Text foodText;
    public Text stoneText;
    public Text copperText;

    public Text silverText;
    [SerializeField]
    public Text goldText;
    
    [SerializeField]
    public int gold = 250;
    public int food;
    public int stone;
    public int copper;
    public int silver;





    public void sellFood(int amount)
    {

        if (food >= amount)
        {
            ModifyFood(-1 * amount);
            ModifyGold(amount);
        }
        else
        {
            //don't sell
        }
    }
  

    public void ModifyGold(int _gold)
    {
        gold += _gold;
    }
    public void ModifyFood(int _food)
    {
        food += _food;
    }
    public void ModifyStone(int _stone)
    {
        stone += _stone;
    }
    public void ModifyCopper(int _copper)
    {
        copper += _copper;
    }
    public void ModifySilver(int _silver)
    {
        silver += _silver;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    public int Gold()
    {
        return gold;
    }
    public int Food()
    {
        return food;
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
    // Update is called once per frame
    void Update()
    {
         goldText.text = "Gold: " + gold.ToString();
         foodText.text = food.ToString();
         stoneText.text = stone.ToString();
         copperText.text = copper.ToString();
         silverText.text = silver.ToString();
    }
}
