using UnityEngine;

[SelectionBase]
public class Player : MonoBehaviour, IWeaponHolder
{
    [SerializeField] private Transform _gunSoket;
    private WeaponAbstract _currentWeapon;
    private Vector3 _dropDistance = new Vector3(3, 0, 0);

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
            _currentWeapon?.Shoot();
        else if (Input.GetMouseButtonDown(1) && _currentWeapon != null)
            DropWeapon();
    }

    public void SetWeapon(WeaponAbstract weapon)
    {
        if (_currentWeapon != null)
            return;

        _currentWeapon = weapon;
        _currentWeapon.transform.SetParent(_gunSoket);
        _currentWeapon.transform.position = _gunSoket.transform.position;
    }

    public void DropWeapon()
    {
        _currentWeapon.transform.position = _gunSoket.transform.position + _dropDistance;
        _currentWeapon.transform.parent = null;
        _currentWeapon = null;
    }
}
