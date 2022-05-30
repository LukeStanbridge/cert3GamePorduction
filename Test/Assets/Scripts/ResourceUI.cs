using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceUI : MonoBehaviour
{
    Camera camLookAt;

    // Start is called before the first frame update
    void Start()
    {
        camLookAt = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(camLookAt.transform);
        transform.rotation = Quaternion.LookRotation(camLookAt.transform.forward);
    }
}
