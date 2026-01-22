using UnityEngine;

public class MovementSimple : MonoBehaviour
{

    void Update()
    {
        Vector3 position = transform.position;

        // Abajo (-Y) y derecha (+X)
        Vector3 direction = new Vector3(-1f, 1f, 0f).normalized;

        position = position + direction * Time.deltaTime;

        transform.position = position;
    }
}
