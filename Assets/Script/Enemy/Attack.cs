
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int damage = 20;
    public float attackCooldown = 1.5f;
    public float attackRange = 2.0f;
    private float lastAttackTime;

    public void PerformAttack(Transform target)
    {
        if(Time.time < lastAttackTime + attackCooldown) return;

        float distanceToTarget = Vector3.Distance(transform.position, target.position);

        if(distanceToTarget <= attackRange)
        {
            Health health = target.GetComponent<Health>();
            if(health != null)
            {
                health.TakeDamage(damage);
                lastAttackTime = Time.time;
            }
        }
    }
}
