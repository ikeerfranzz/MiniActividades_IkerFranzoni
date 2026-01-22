using UnityEngine;

public class ScriptE46Personaje2 : MonoBehaviour
{
    public Transform target;
    public float maxSpeed = 5f;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (target == null) return;

        Vector2 direction = (target.position - transform.position);
        Vector2 desiredVelocity = direction.normalized * maxSpeed;

        rb.linearVelocity = new Vector2(
            Mathf.Lerp(rb.linearVelocity.x, desiredVelocity.x, Time.fixedDeltaTime * 5f),
            rb.linearVelocity.y
        );
    }
}

