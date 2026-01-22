using UnityEngine;

public class ScriptE46Personaje : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad modificable

    void Update()
    {
        Vector3 direccion = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
            direccion.x = -1;

        if (Input.GetKey(KeyCode.D))
            direccion.x = 1;

        // Para que no se mueva m�s r�pido en diagonal
        direccion = direccion.normalized;


        transform.position = transform.position + direccion * velocidad * Time.deltaTime;
    }
}
