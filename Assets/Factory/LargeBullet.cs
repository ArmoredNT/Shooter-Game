using UnityEngine;

namespace Factory
{
    public class LargeBullet : BulletFactory
    {
        [SerializeField] Large bulletPrefab;
        public override IBullet SpawnIBullet(Vector3 direction, Vector3 position)
        {
            GameObject bullet = Instantiate(bulletPrefab.gameObject, position, Quaternion.identity);
            Large large = bullet.GetComponent<Large>();
            large.Initialize(direction);
            return large;
        }
    }
}
