using UnityEngine;

public class ScriptE60 : MonoBehaviour
{
    public float velocidadE60 = 5f; // Velocidad modificable
    public GameObject objectToSpawn;  // Spawn
    float contador= 0f;

    void Update()
    {
        Vector3 direccion = Vector3.zero;
        
        if (Input.GetKey(KeyCode.A))
            direccion.x = -1;

        if (Input.GetKey(KeyCode.D))
            direccion.x = 1;

        // Normalizamos para que no se mueva m�s r�pido en diagonal
        direccion = direccion.normalized;


        transform.position = transform.position + direccion * velocidadE60 * Time.deltaTime;

        // Spawn al pulsar espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
            contador ++;
            Debug.Log (contador);
        }
    }

    
}
