using System;
using UnityEngine;

public class Small : MonoBehaviour, IBullet
{
    private Vector3 dir;
    Rigidbody2D rb;
    public void Initialize(Vector3 direction)
    {
        dir = direction;
        rb = GetComponent<Rigidbody2D>();
        
        rb.AddForce(dir * 10, ForceMode2D.Impulse);
    }

    private void Update()
    {
        
        //transform.position += dir * Time.deltaTime;
            //Translate(dir * Time.deltaTime);
    }
}
