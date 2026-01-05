using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public EnemyAttack attack;

    public float moveSpeed = 3f;
    public float attackRange = 1.5f;

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= attackRange)
        {
            AttackPlayer();
        }
        else
        {
            ChasePlayer(); // ALWAYS chase
        }
    }

    void ChasePlayer()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            player.position,
            moveSpeed * Time.deltaTime
        );
    }

    void AttackPlayer()
    {
        attack.PerformAttack(player);
    }
}
