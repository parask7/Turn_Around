
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage = 5;
    public float attackCooldown = 1.5f;
    public float attackRange = 2.0f;
    private float lastAttackTime;

    public void PerformAttack(Transform target)
    {
        if(Time.time < lastAttackTime + attackCooldown) return;

        float distanceToTarget = Vector3.Distance(transform.position, target.position);

        if(distanceToTarget <= attackRange)
        {
            PlayerHealth health = target.GetComponent<PlayerHealth>();
            if(health != null)
            {
                health.TakeDamage(damage);
                lastAttackTime = Time.time;
            }
        }
    }
}
