using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float maxTime = 1.0f;
    [SerializeField] private float maxDistance = 1.0f;
    float timer = 0.0f;

    Animator animator;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0.0f)
        {
            float sqDistance = (playerTransform.position - agent.destination).sqrMagnitude;
            if (sqDistance > maxDistance * maxDistance)
            {
                agent.destination = playerTransform.position;
            }
            timer = maxTime;
        }
        animator.SetFloat("Speed", agent.velocity.magnitude);
    }
    //https://www.youtube.com/watch?v=TpQbqRNCgM0 - follow AI
    //https://www.youtube.com/watch?v=oLT4k-lrnwg - damage AI
    //https://www.youtube.com/watch?v=1H9jrKyWKs0 - managing enemy state
    //https://www.youtube.com/watch?v=Tf4TpNnwSd4 - AI shooting
}
