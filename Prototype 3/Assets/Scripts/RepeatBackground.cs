using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - 56) // Initialement 40/50 - 56 boucle parfaitement avec la caméra
        {
            transform.position = startPos;
        }

    }
}
