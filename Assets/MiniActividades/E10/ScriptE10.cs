using UnityEngine;

public class OperacionAleatoria : MonoBehaviour
{
    void Start()
    {
        float numeroA = Random.Range(1f, 10f);
        float numeroB = Random.Range(1f, 10f);

        int operacion = Random.Range(0, 5);
        float resultado = 0f;

        if (operacion == 0)
        {
            resultado = numeroA + numeroB;
            Debug.Log(numeroA + " + " + numeroB + " = " + resultado);
        }
        else if (operacion == 1)
        {
            resultado = numeroA - numeroB;
            Debug.Log(numeroA + " - " + numeroB + " = " + resultado);
        }
        else if (operacion == 2)
        {
            resultado = numeroA * numeroB;
            Debug.Log(numeroA + " * " + numeroB + " = " + resultado);
        }
        else if (operacion == 3)
        {
            resultado = numeroA / numeroB;
            Debug.Log(numeroA + " / " + numeroB + " = " + resultado);
        }
        else if (operacion == 4)
        {
            resultado = numeroA % numeroB;
            Debug.Log(numeroA + " % " + numeroB + " = " + resultado);
        }
    }
}
