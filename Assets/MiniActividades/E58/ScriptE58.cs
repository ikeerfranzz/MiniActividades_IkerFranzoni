using UnityEngine;

public class ScriptE58 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){//Si se presiona el espacio
            Physics2D.gravity = -Physics2D.gravity;//Se invierte la gravedad
        }
    }
}
