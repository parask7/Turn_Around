using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyPatrol : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float speed = 3f;
    public float reachDistance = 0.3f;

    private Rigidbody rb;
    private int currentPointIndex = 0;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (patrolPoints == null || patrolPoints.Length == 0)
            return;

        MoveToPoint();
    }

    void MoveToPoint()
    {
        Transform target = patrolPoints[currentPointIndex];

        Vector3 direction = (target.position - transform.position);
        direction.y = 0f;

        float distance = direction.magnitude;

        if (distance <= reachDistance)
        {
            currentPointIndex = (currentPointIndex + 1) % patrolPoints.Length;
            return;
        }

        direction.Normalize();

        rb.linearVelocity = new Vector3(
            direction.x * speed,
            rb.linearVelocity.y,
            direction.z * speed
        );
    }
}
