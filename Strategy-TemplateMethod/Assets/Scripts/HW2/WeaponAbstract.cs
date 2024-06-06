using UnityEngine;

public abstract class WeaponAbstract : MonoBehaviour
{
    [field: SerializeField] protected Transform spawnBulletPoint { get; private set; }
    [field: SerializeField] protected Bullet bulletPrefab { get; private set; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IWeaponHolder weaponHolder))
            weaponHolder.SetWeapon(this);
    }
    public abstract void Shoot();

}
