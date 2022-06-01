using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceUI : MonoBehaviour
{
    Camera camLookAt;

    void Start()
    {
        camLookAt = Camera.main;
    }

    void Update()
    {
        transform.LookAt(camLookAt.transform);
        transform.rotation = Quaternion.LookRotation(camLookAt.transform.forward); // label always faces cam
    }
}
