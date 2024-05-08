using UnityEngine;

public class Dragon : Enemy
{
    private int _health = 1000;

    
    public override void TakeDamage(int damageValue)
    {
        if (_health <= 0)
            Debug.Log("Дракон мертв!");

        _health -= damageValue;
    }

}
