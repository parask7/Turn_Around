using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public Attack attack;

    public float chaseRange = 8f;
    public float attackRange = 1.5f;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= chaseRange)
        {
            if (distance <= attackRange)
            {
                attack.PerformAttack(player);
            }
            else
            {
                ChasePlayer();
            }
        }
    }

    void ChasePlayer()
    {
        transform.LookAt(player);
        transform.position = Vector3.MoveTowards(
            transform.position,
            player.position,
            3f * Time.deltaTime
        );
    }
}
