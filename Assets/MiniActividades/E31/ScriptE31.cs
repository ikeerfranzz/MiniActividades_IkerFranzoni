using UnityEngine;

public class ScriptE31 : MonoBehaviour
{
    public float speed = 5f;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

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
        // Al entrar en el objeto estático pasa a ser rojo
        spriteRenderer.color = Color.red;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Al salir del objeto estático pasa a ser blanco
        spriteRenderer.color = Color.white;
    }
}
