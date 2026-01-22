using UnityEngine;

public class ScriptE28 : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad editable desde el Inspector

    void FixedUpdate()
    {
        Vector2 direccion = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
            direccion.y = 1;

        if (Input.GetKey(KeyCode.S))
            direccion.y = -1;

        if (Input.GetKey(KeyCode.A))
            direccion.x = -1;

        if (Input.GetKey(KeyCode.D))
            direccion.x = 1;

        // Para que no vaya más rápido en diagonal
        direccion = direccion.normalized;

        transform.position = transform.position + (Vector3)(direccion * velocidad * Time.fixedDeltaTime);
    }
}
