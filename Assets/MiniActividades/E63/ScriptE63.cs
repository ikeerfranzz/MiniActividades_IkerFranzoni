using UnityEngine;

public class ScriptE63 : MonoBehaviour
{
    public float speed = 5f;
    public GameObject objetoSpawn;
    public AudioSource audioSource;

    void Update()
    {
        float moverX = 0f;
        float moverY = 0f;

        if (Input.GetKey(KeyCode.A)) moverX = -1f;
        if (Input.GetKey(KeyCode.D)) moverX =  1f;
        if (Input.GetKey(KeyCode.W)) moverY =  1f;
        if (Input.GetKey(KeyCode.S)) moverY = -1f;

        Vector3 movimiento = new Vector3(moverX, moverY, 0f).normalized;
        transform.position += movimiento * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objetoSpawn, transform.position, Quaternion.identity);
        }
    }
}
