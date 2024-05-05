using UnityEngine;

public abstract class WeaponAbstract : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnBulletPoint;
    public Rigidbody bulletRb => bulletPrefab.GetComponent<Rigidbody>();

	private int _shotSpeed = 1500;

	public int ShotSpeed
	{
		get { return _shotSpeed; }
		private set { _shotSpeed = value; }
	}

	public abstract void Shot(); 

}
