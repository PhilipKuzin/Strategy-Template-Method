using UnityEngine;

public class Pistol : WeaponAbstract
{
    public override void Shoot()
    {
        bulletPrefab.Launch(spawnBulletPoint);
    }
}
