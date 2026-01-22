using UnityEngine;
using UnityEngine.InputSystem;

public class ScriptE23 : MonoBehaviour
{
    private bool saltoPosible = true;
    private Rigidbody2D rigidBody;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && saltoPosible)
        {
            rigidBody.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
            saltoPosible = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        saltoPosible = true;
    }

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
}
