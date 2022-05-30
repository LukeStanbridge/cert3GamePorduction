using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public float goldCollected;

    public void ItemCollected()
    {
        goldCollected++;;
    }
}
