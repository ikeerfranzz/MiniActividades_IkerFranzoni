using UnityEngine;

public class ScriptE61 : MonoBehaviour
{
    public float speed = 5f; // Velocidad modificable
    public GameObject objectToSpawn;  // Spawn
    float contador= 0f;

    void Update()
    {
        Vector3 direccion = Vector3.zero;
        
       float moverX = 0f;
        float moverY = 0f;

        if (Input.GetKey(KeyCode.A)) moverX = -1f;
        if (Input.GetKey(KeyCode.D)) moverX =  1f;
        if (Input.GetKey(KeyCode.W)) moverY =  1f;
        if (Input.GetKey(KeyCode.S)) moverY = -1f;

        Vector3 movimiento = new Vector3(moverX, moverY, 0f).normalized;
        transform.position += movimiento * speed * Time.deltaTime;
        
        // Spawn al pulsar espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
            contador ++;
            Debug.Log (contador);
        }
    }

    
}
