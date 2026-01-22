using UnityEngine;

public class ScriptE14 : MonoBehaviour
{
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log("Table del " + i);

            for (int j = 1; j <= 10; j++)
            {
                Debug.Log(i + " x " + j + " = " + (i * j));
            }
        }
    }
}
