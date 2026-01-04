using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    [Header("Attack Settings")]
    public int damage = 25;
    public float attackRange = 2f;
    public float attackCooldown = 1f;
    public LayerMask enemyLayer;

    private float lastAttackTime;

    void Update()
    {
        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            TryAttack();
        }
    }

    void TryAttack()
    {
        // Cooldown check
        if (Time.time < lastAttackTime + attackCooldown)
            return;

        // Detect enemies in range
        Collider[] hits = Physics.OverlapSphere(
            transform.position,
            attackRange,
            enemyLayer
        );

        if (hits.Length == 0)
        {
            Debug.Log("No enemy in range");
            return;
        }

        foreach (Collider hit in hits)
        {
            EnemyHealth enemyHealth = hit.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damage);
                lastAttackTime = Time.time;
                Debug.Log("Enemy Hit!");
                break;
            }
        }
    }

    // Visualize attack range in Scene view
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
