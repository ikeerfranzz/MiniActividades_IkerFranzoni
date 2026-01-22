using UnityEngine;

public class Scripy : MonoBehaviour
{
    public int numA;
    public int numB;
    public int numC;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log((numA + numB + numC) / 3);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
