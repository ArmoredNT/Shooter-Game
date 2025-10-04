using UnityEngine;

public class Large : MonoBehaviour, IBullet
{
    private Vector3 dir;
    Rigidbody2D rb;
    public void Initialize(Vector3 direction)
    {
        dir = direction;
        rb = GetComponent<Rigidbody2D>();
        
        rb.AddForce(dir * 3, ForceMode2D.Impulse);
    }
}
