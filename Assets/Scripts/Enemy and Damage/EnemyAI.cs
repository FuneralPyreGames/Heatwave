using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent Agent;
    Transform Player;
    public LayerMask playerLayer;
    public LayerMask groundLayer;
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;
    public float timeBetweenAttacks;
    bool alreadyAttacked;
    public float sightRange;
    public float attackRange;
    public bool playerInSightRange;
    public bool playerInAttackRange;
    public GameObject Gun;
    [SerializeField] EnemyGun enemyGun;
    void Awake()
    {
        Player = GameObject.Find("Player").transform;
        Agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, playerLayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, playerLayer);
        if (playerInSightRange == false && playerInAttackRange == false)
        {
            Patroling();
        }
        if (playerInSightRange == true && playerInAttackRange == false)
        {
            ChasePlayer();
        }
        if (playerInSightRange == true && playerInAttackRange == true)
        {
            AttackPlayer();
        }
    }
    void Patroling()
    {
        if (walkPointSet == false)
        {
            SearchWalkPoint();
        }
        if (walkPointSet == true)
        {
            Agent.SetDestination(walkPoint);
            
        }
        Vector3 distanceToWalkPoint = transform.position - walkPoint;
        if (distanceToWalkPoint.magnitude < 1f)
        {
            walkPointSet = false;
        }
    }
    void SearchWalkPoint()
    {
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomx = Random.Range(-walkPointRange, walkPointRange);
        walkPoint = new Vector3(transform.position.x + randomx, transform.position.y, transform.position.z + randomZ);
        if (Physics.Raycast(walkPoint, -transform.up, 2f, groundLayer))
        {
            walkPointSet = true;
        }
    }
    void ChasePlayer()
    {
        Agent.SetDestination(Player.position);
    }
    void AttackPlayer()
    {
        Agent.SetDestination(transform.position);
        transform.LookAt(Player);
        if (!alreadyAttacked)
        {
            enemyGun.Shoot();
            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }
    void ResetAttack()
    {
        alreadyAttacked = false;
    }
}
