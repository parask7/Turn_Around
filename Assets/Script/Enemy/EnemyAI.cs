using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public EnemyAttack attack;

    [Header("Patrol")]
    public Transform[] patrolPoints;
    public float patrolSpeed = 2f;
    public float reachPointThreshold = 0.5f;
    private int currentPatrolIndex = 0;

    [Header("Ranges")]
    public float chaseRange = 8f;
    public float attackRange = 1.5f;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= attackRange)
        {
            AttackPlayer();
        }
        else if (distance <= chaseRange)
        {
            ChasePlayer();
        }
        else
        {
            Patrol();
        }
    }

    // ---------------- PATROL ----------------
    void Patrol()
    {
        if (patrolPoints.Length == 0) return;

        Transform targetPoint = patrolPoints[currentPatrolIndex];

        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPoint.position,
            patrolSpeed * Time.deltaTime
        );

        if (Vector3.Distance(transform.position, targetPoint.position) <= reachPointThreshold)
        {
            currentPatrolIndex++;

            if (currentPatrolIndex >= patrolPoints.Length)
                currentPatrolIndex = 0;
        }
    }

    // ---------------- CHASE ----------------
    void ChasePlayer()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            player.position,
            3f * Time.deltaTime
        );
    }

    // ---------------- ATTACK ----------------
    void AttackPlayer()
    {
        attack.PerformAttack(player);
    }
}
