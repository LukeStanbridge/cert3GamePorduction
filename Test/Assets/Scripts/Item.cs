using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private float rotateAmount = 0.3f; // rotate speed
    public float gold = 0f;
    public float silver = 0f;
    public float copper = 0f;
    public float stone = 0f;
    public float wood = 0f;
    public float food = 0f;

    void Update()
    {
        transform.Rotate(Vector3.up * rotateAmount); // rotate item on spot
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            if (other.name == "Gold")
            {
                gameObject.SetActive(false);
                gold += 10f;
            }
            else if (other.name == "Silver")
            {
                gameObject.SetActive(false);
                silver += 10f;
            }
            else if (other.name == "Copper")
            {
                gameObject.SetActive(false);
                copper += 10f;
            }
            else if (other.name == "Stone")
            {
                gameObject.SetActive(false);
                stone += 10f;
            }
            else if (other.name == "Wood")
            {
                gameObject.SetActive(false);
                wood += 10f;
            }
            else if (other.name == "Food")
            {
                gameObject.SetActive(false);
                food += 10f;
            }
        }
    }
}
