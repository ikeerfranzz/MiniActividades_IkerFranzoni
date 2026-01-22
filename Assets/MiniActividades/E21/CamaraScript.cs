using UnityEngine;

public class CamaraScript : MonoBehaviour
{
    public GameObject target;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    void Update()
    {
        transform.position = target.transform.position + offset;
    }
}