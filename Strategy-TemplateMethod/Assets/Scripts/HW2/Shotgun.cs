using UnityEngine;

public class Shotgun : WeaponAbstract
{
    private int _ammoCount = 30;
    private int _shellsInShot = 3;
    public override void Shoot()
    {
        if (_ammoCount <= _shellsInShot)
            return;
        for (int i = 0; i < _shellsInShot; i++) 
        {
            bulletPrefab.Launch(spawnBulletPoint);
        }
        _ammoCount = _ammoCount - _shellsInShot;
    }

}
