using UnityEngine;

public class ScriptE11 : MonoBehaviour
{
    public int jugadorA; 
    public int jugadorB;

    void Start()
    {
        // Generar jugada del jugador B
        jugadorB = Random.Range(1, 4);

        // Mostrar qué juega cada uno
        Debug.Log("Jugada del jugador A" + HandToString(jugadorA));
        Debug.Log("Jugada del jugador B" + HandToString(jugadorB));

        // Comprobar empate
        if (jugadorA == jugadorB)
        {
            Debug.Log("Resultado: Empate");
            return;
        }

        // Combinaciones ganadoras
        if (jugadorA == 1 && jugadorB == 3 ||
            jugadorA == 2 && jugadorB == 1 ||
            jugadorA == 3 && jugadorB == 2)
        {
            Debug.Log("Resultado: Jugador A gana");
        }
        else
        {
            Debug.Log("Resultado: Jugador B gana");
        }
    }

    string HandToString(int hand)
    {
        if (hand == 1) return "Piedra";
        if (hand == 2) return "Papel";
        if (hand == 3) return "Tijeras";
        return "No valido";
    }
}
