using UnityEngine;

[SelectionBase]
public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _gunSoket;
    private WeaponAbstract _currentWeapon;
    private Vector3 _dropDistance = new Vector3(3, 0, 0);

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
            _currentWeapon?.Shot();
        else if (Input.GetMouseButtonDown(1) && _currentWeapon != null)
            DropWeapon();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_currentWeapon != null) 
            return;
        if (other.TryGetComponent(out WeaponAbstract weapon))
            SetWeapon(weapon);
    }
    private void SetWeapon(WeaponAbstract weapon)
    {
        _currentWeapon = weapon;
        _currentWeapon.transform.SetParent(transform);
        _currentWeapon.transform.position = _gunSoket.transform.position;
    }
    private void DropWeapon()
    {
        _currentWeapon.transform.position = _gunSoket.transform.position + _dropDistance;
        _currentWeapon.transform.parent = null;
        _currentWeapon = null;
    }
}
