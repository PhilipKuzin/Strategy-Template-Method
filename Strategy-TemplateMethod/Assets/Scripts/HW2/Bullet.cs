using UnityEngine;

[RequireComponent(typeof(Renderer))]
[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    public Rigidbody bulletRb => GetComponent<Rigidbody>();

    private int _shotSpeed = 1500;

    public int ShotSpeed
    {
        get { return _shotSpeed; }
        private set { _shotSpeed = value; }
    }
    public Rigidbody Launch (Transform spawnPoint)
    {
        Rigidbody cloneBullet;
        cloneBullet = Instantiate(bulletRb, spawnPoint.position, spawnPoint.rotation);
        cloneBullet.AddForce(spawnPoint.transform.forward * ShotSpeed);

        return cloneBullet;
    }
}
