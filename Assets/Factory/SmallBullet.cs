using UnityEngine;

namespace Factory
{
    public class SmallBullet : BulletFactory
    {
        [SerializeField] Small bulletPrefab;
        public override IBullet SpawnIBullet(Vector3 direction, Vector3 position)
        {
            GameObject bullet = Instantiate(bulletPrefab.gameObject, position, Quaternion.identity);
            Small small = bullet.GetComponent<Small>();
            small.Initialize(direction);
            return small;
        }
    }
}
