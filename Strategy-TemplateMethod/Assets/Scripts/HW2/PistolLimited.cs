using UnityEngine;

public class PistolLimited : WeaponAbstract
{
    private int _ammoCount = 10;
    public override void Shot()
    {
        if (_ammoCount <= 0)
            return;
        Rigidbody cloneBullet;
        cloneBullet = Instantiate(bulletRb, spawnBulletPoint.position, spawnBulletPoint.rotation);
        cloneBullet.AddForce(spawnBulletPoint.transform.forward * ShotSpeed);
        _ammoCount--;
    }
}
