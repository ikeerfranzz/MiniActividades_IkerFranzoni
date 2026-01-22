using UnityEngine;

public class ScriptE15 : MonoBehaviour
{
    public int jugadorA;
    public int jugadorB;

    int jugadorAwin = 0;
    int jugadorBwin = 0;

    void Start()
    {
        int ronda = 1;

        while (jugadorAwin < 5 && jugadorBwin < 5)
        {
            Debug.Log("---- Ronda " + ronda + " ----");

            // Jugadas aleatorias
            jugadorA = Random.Range(1, 4);
            jugadorB = Random.Range(1, 4);

            Debug.Log("Jugador A juega: " + HandToString(jugadorA));
            Debug.Log("Jugador B juega: " + HandToString(jugadorB));

            // Empate
            if (jugadorA == jugadorB)
            {
                Debug.Log("Empate");
            }
            // Jugador A gana
            else if (
                jugadorA == 1 && jugadorB == 3 ||
                jugadorA == 2 && jugadorB == 1 ||
                jugadorA == 3 && jugadorB == 2
            )
            {
                jugadorAwin++;
                Debug.Log("Gana la ronda el Jugador A");
            }
            // Jugador B gana
            else
            {
                jugadorBwin++;
                Debug.Log("Gana la ronda el Jugador B");
            }

            Debug.Log("Marcador A: " + jugadorAwin + " | B: " + jugadorBwin);
            ronda++;
        }

        // Ganador final
        if (jugadorAwin == 5)
        {
            Debug.Log("JUGADOR A GANA LA PARTIDA");
        }
        else
        {
            Debug.Log("JUGADOR B GANA LA PARTIDA");
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
