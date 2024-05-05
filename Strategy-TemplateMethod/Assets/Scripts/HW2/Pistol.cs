using UnityEngine;

public class Pistol : WeaponAbstract
{
    public override void Shot()
    {
        Rigidbody cloneBullet;
        cloneBullet = Instantiate(bulletRb, spawnBulletPoint.position, spawnBulletPoint.rotation);
        cloneBullet.AddForce(spawnBulletPoint.transform.forward * ShotSpeed);
    }
}
