using UnityEngine;

public class Shotgun : WeaponAbstract
{
    private int _ammoCount = 30;
    private int _shellsInShot = 3;
    public override void Shot()
    {
        if (_ammoCount <= 0)
            return;
        for (int i = 0; i < _shellsInShot; i++) 
        {
            Rigidbody cloneBullet;
            cloneBullet = Instantiate(bulletRb, spawnBulletPoint.position, spawnBulletPoint.rotation);
            cloneBullet.AddForce(spawnBulletPoint.transform.forward * ShotSpeed);
        }
        _ammoCount = _ammoCount - _shellsInShot;
    }

}
