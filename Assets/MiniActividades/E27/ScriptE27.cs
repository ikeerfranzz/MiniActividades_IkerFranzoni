using UnityEngine;

public class GravedadInvertida : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad modificable


    public float impulso = 6f; // Fuerza del impulso al tocar el suelo

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Comprobamos que ha chocado con el suelo
        if (collision.gameObject.CompareTag("Suelo"))
        {
            // Impulso hacia arriba
            GetComponent<Rigidbody2D>().AddForce(
                Vector2.up * impulso,
                ForceMode2D.Impulse
            );
        }
    }
    void Update()
    {
        Vector3 direccion = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            direccion.y = 1;

        if (Input.GetKey(KeyCode.S))
            direccion.y = -1;

        if (Input.GetKey(KeyCode.A))
            direccion.x = -1;

        if (Input.GetKey(KeyCode.D))
            direccion.x = 1;

        // Para que no se mueva m�s r�pido en diagonal
        direccion = direccion.normalized;


        transform.position = transform.position + direccion * velocidad * Time.deltaTime;
    }
}
