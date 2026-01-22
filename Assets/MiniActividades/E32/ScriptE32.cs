using UnityEngine;

public class ScriptE32 : MonoBehaviour
{
    public float speed = 5f;

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
        if (other.CompareTag("Objeto1"))
        {
            Debug.Log("Ha entrado en el Objeto 1");
        }
        else if (other.CompareTag("Objeto2"))
        {
            Debug.Log("Ha entrado en el Objeto 2");
        }
    }
}
