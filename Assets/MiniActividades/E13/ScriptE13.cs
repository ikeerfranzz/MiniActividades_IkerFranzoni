using UnityEngine;

public class ScriptE13 : MonoBehaviour
{
    void Start()
    {
        int count = 0;

        while (count < 100)
        {
            int numeroAleatorio = Random.Range(0, 100);
            Debug.Log(numeroAleatorio);
            count++;
        }
    }
}
