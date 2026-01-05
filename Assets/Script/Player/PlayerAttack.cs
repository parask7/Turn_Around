using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public int damage = 25;
    public float attackRange = 2f;
    public LayerMask enemyLayer;

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            PerformAttack();
        }
    }

    void PerformAttack()
    {
        Collider[] hits = Physics.OverlapSphere(
            transform.position,
            attackRange,
            enemyLayer
        );

        if (hits.Length == 0)
        {
            Debug.Log("No enemies hit");
            return;
        }

        foreach (Collider hit in hits)
        {
            EnemyHealth health = hit.GetComponent<EnemyHealth>();
            if (health != null)
            {
                health.TakeDamage(damage);
            }
        }

        Debug.Log("Enemies Hit: " + hits.Length);
    }

    // Optional visual aid
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
