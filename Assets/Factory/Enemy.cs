using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    private float timer = 0;

    private float respawnSpeed = 5;

    private Vector3 start;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * (Time.deltaTime * 5f * -1);
        timer += Time.deltaTime;

        if (timer >= respawnSpeed)
        {
            timer = 0;
            transform.position = start;
        }
    }
}
