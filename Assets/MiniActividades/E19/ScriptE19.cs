using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    float velocidad = 5f; // Velocidad modificable

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

        // Normalizamos para que no se mueva m�s r�pido en diagonal
        direccion = direccion.normalized;


        transform.position = transform.position + direccion * velocidad * Time.deltaTime;
    }
}
