using UnityEngine;

public class Calculadora : MonoBehaviour
{
    public float numero1;
    public float numero2;
    public string operacion;

    void Start()
    {
        float resultado = 0f;

        switch (operacion)
        {
            case "+":
                resultado = numero1 + numero2;
                break;

            case "-":
                resultado = numero1 - numero2;
                break;

            case "*":
                resultado = numero1 * numero2;
                break;

            case "/":
                if (numero2 != 0)
                    resultado = numero1 / numero2;
                else
                {
                    Debug.Log("Error: división entre cero");
                    return;
                }
                break;

            case "%":
                resultado = numero1 % numero2;
                break;

            default:
                Debug.Log("Operación no válida");
                return;
        }

        Debug.Log("Resultado: " + resultado);
    }
}
