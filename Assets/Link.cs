using UnityEngine;

public class Link : MonoBehaviour
{
    Vector3 direction;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
        direction.z = 0;

        if (direction.magnitude > 0.1f)
        {
            transform.position += direction.normalized * (3 * Time.deltaTime);
            
            //rb.AddForce(direction * 3, ForceMode2D.Force);
        }
        
    }
}
