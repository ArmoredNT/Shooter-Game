using System;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private GameObject loss;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        loss.SetActive(true);
        Destroy(other.gameObject);
    }
}
