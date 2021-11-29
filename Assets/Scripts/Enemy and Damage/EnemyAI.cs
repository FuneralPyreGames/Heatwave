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
    public Vector3 attackWalkPoint;
    public bool resettingAttack = false;
    bool walkPointSet;
    bool attackwalkPointSet;
    public float walkPointRange;
    public float attackWalkPointRange;
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
    void SearchAttackWalkPoint()
    {
        float randomZ = Random.Range(-attackWalkPointRange, attackWalkPointRange);
        float randomx = Random.Range(-attackWalkPointRange, attackWalkPointRange);
        attackWalkPoint = new Vector3(transform.position.x + randomx, transform.position.y, transform.position.z + randomZ);
        print(attackWalkPoint);
        if (Physics.Raycast(walkPoint, -transform.up, 2f, groundLayer))
        {
            attackwalkPointSet = true;
        }
        print("Attack walk point set");
    }
    void ChasePlayer()
    {
        Agent.SetDestination(Player.position);
    }
    void AttackPlayer()
    {
        transform.LookAt(Player);
        if (!alreadyAttacked)
        {
            enemyGun.Shoot();
            alreadyAttacked = true;
        }
        AfterAttackWalk();
    }
    void AfterAttackWalk()
    {
        if (!resettingAttack)
        {
            print("After attack walk");
            if (attackwalkPointSet == false)
            {
                print("searching for attack walk point");
                SearchAttackWalkPoint();
            }
            if (attackwalkPointSet == true)
            {
                print("Agent destination set");
                Agent.SetDestination(walkPoint);
            }
            Vector3 distanceToWalkPoint = transform.position - attackWalkPoint;
            if (distanceToWalkPoint.magnitude < 1f)
            {
                print("Walked to attack");
                ResetAttack();
            } 
        }
        
    }
    IEnumerator ResetAttack()
    {
        print("Resetting attack");
        resettingAttack = true;
        yield return new WaitForSeconds(timeBetweenAttacks);
        alreadyAttacked = false;
        resettingAttack = false;
    }
}
