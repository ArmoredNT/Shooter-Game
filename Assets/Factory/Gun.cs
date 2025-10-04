using Factory;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private float fireSpeed;

    [SerializeField] private BulletFactory[] bulletFactory;
    private float timer;

    private int spawnNum = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= fireSpeed)
        {
            timer = 0;
            bulletFactory[spawnNum].SpawnIBullet(Vector3.up, transform.position);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            spawnNum = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spawnNum = 1;
        }
            
    }
}
