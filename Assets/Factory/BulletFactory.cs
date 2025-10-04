using UnityEngine;

namespace Factory
{
    public abstract class BulletFactory : MonoBehaviour
    {
        public abstract IBullet SpawnIBullet(Vector3 direction, Vector3 position);
    }
    
}
