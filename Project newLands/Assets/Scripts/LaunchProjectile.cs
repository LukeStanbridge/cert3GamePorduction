using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public GameObject projectile;
    public GameObject target;
    float timer;
    public GameObject enemyAI;

    private void Awake()
    {
        enemyAI = GameObject.FindGameObjectWithTag("Enemy");
    }
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyAI.GetComponent<EnemyAI>().playerInSightRange)
        {
            transform.LookAt(target.transform.position);
            ShootProjectile();
        }
    }

    void ShootProjectile()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            GameObject fire = (GameObject)Instantiate(projectile, transform.position, Quaternion.identity);
            fire.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            Destroy(fire, 2);
            timer = 0;
        }
    }
}
