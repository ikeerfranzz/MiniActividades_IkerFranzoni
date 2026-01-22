using UnityEngine;

public class MovementSimpleE17 : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        Vector3 position = transform.position;

       
        Vector3 direction = new Vector3(-1f, 1f, 0f).normalized;

        position = position + direction * speed * Time.deltaTime;

        transform.position = position;
    }
}