using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] private float maxTime = 1.0f;
    [SerializeField] private float maxDistance = 1.0f;
    float timer = 0.0f;
    public int hitCounter;

    public Transform player;
    public float sightRange;
    public LayerMask whatIsPlayer;
    public bool playerInSightRange;

    Animator animator;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        hitCounter = 0;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer); // check for sight range

        if (playerInSightRange) ChasePlayer(); // follow and attack player with poo
        else animator.SetFloat("Speed", 0); // stop player from playing ruinning animation

        if (hitCounter >= 3)
        {
            sightRange = 0; // stop dead player from following player
            Die(); // play death animation
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            hitCounter++;
        }
    }

    private void Die()
    {
        animator.SetTrigger("death");
        Destroy(this.gameObject, 5);
    }

    private void ChasePlayer()
    {
        timer -= Time.deltaTime;
        if (timer < 0.0f)
        {
            float sqDistance = (player.position - agent.destination).sqrMagnitude;
            if (sqDistance > maxDistance * maxDistance)
            {
                agent.destination = player.position;
            }
            timer = maxTime;
        }
        animator.SetFloat("Speed", agent.velocity.magnitude);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }
}
