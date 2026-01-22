using UnityEngine;

public class ScriptE30ObjetoCollider : MonoBehaviour
{
    void Start()
    {
    Debug.Log("objetoEstatico activo");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("El personaje HA ENTRADO en el objeto estático");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("El personaje HA SALIDO del objeto estático");
    }
}
