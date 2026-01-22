using UnityEngine;

public class ScriptE59 : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        float moverX = 0f;
        float moverY = 0f;

        if (Input.GetKey(KeyCode.A)) moverX = -1f;
        if (Input.GetKey(KeyCode.D)) moverX =  1f;

        Vector3 movement = new Vector3(moverX, moverY, 0f).normalized;
        transform.position += movement * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.Space)){
           transform.position = new Vector3 (0,0,0);
        }
    }
}
