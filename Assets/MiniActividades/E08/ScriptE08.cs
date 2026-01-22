using UnityEngine;

public class ScriptE08 : MonoBehaviour
{
    public float numero;

    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            float resultado = numero * i;
            Debug.Log(numero + " * " + i + " = " + resultado);
        }
    }
}
