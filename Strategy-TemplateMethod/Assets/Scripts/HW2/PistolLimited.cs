using UnityEngine;

public class PistolLimited : WeaponAbstract
{
    private int _ammoCount = 10;
    public override void Shoot()
    {
        if (_ammoCount <= 0)
            return;

        bulletPrefab.Launch(spawnBulletPoint);
        _ammoCount--;
    }
}
