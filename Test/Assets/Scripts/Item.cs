using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private float rotateAmount = 0.3f; // set rotate speed

    void Update()
    {
        transform.Rotate(Vector3.up * rotateAmount); // rotate item on spot
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            gameObject.SetActive(false); // remove object when hit
        }
    }
}
