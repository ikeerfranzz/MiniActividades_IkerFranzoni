using UnityEngine;

public class ScriptE42 : MonoBehaviour
{
    public float speed = 5f;
    int contador = 0;

    void Update()
    {
        float moverX = 0f;
        float moverY = 0f;

        if (Input.GetKey(KeyCode.A)) moverX = -1f;
        if (Input.GetKey(KeyCode.D)) moverX =  1f;
        if (Input.GetKey(KeyCode.W)) moverY =  1f;
        if (Input.GetKey(KeyCode.S)) moverY = -1f;

        Vector3 movement = new Vector3(moverX, moverY, 0f).normalized;
        transform.position += movement * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        contador++;
        Debug.Log("Entradas totales: " + contador);
    }
}
