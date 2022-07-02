using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI goldText;
    private TextMeshProUGUI silverText;
    private TextMeshProUGUI copperText;
    private TextMeshProUGUI foodText;
    private TextMeshProUGUI woodText;
    private TextMeshProUGUI stoneText;

    // Start is called before the first frame update
    void Start()
    {
        goldText = GetComponent<TextMeshProUGUI>();
        silverText = GetComponent<TextMeshProUGUI>();
        copperText = GetComponent<TextMeshProUGUI>();
        foodText = GetComponent<TextMeshProUGUI>();
        woodText = GetComponent<TextMeshProUGUI>();
        stoneText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateGoldText(ResourceManager resourceManager)
    { 
        goldText.text = "Gold: " + resourceManager.gold.ToString();
    }
    public void UpdateSilverText(ResourceManager resourceManager)
    {
        silverText.text = "Silver: " + resourceManager.silver.ToString();
    }
    public void UpdateCopperText(ResourceManager resourceManager)
    {
        copperText.text = "Copper: " + resourceManager.copper.ToString();
    }
    public void UpdateFoodText(ResourceManager resourceManager)
    {
        foodText.text = "Food: " + resourceManager.food.ToString();
    }
    public void UpdateWoodText(ResourceManager resourceManager)
    {
        woodText.text = "Wood: " + resourceManager.wood.ToString();
    }
    public void UpdateStoneText(ResourceManager resourceManager)
    {
        stoneText.text = "Stone: " + resourceManager.stone.ToString();
    }
}
