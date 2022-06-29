using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public GameObject projectile;
    public GameObject target;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform.position);
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            GameObject fire = (GameObject)Instantiate(projectile, transform.position, Quaternion.identity);
            fire.GetComponent<Rigidbody>().AddForce(transform.forward * 2000);
            Destroy(fire, 2);
            timer = 0;
        }
    }
}
