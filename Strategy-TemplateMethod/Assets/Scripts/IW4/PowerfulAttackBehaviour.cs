using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerfulAttackBehaviour : IKnightAttacker
{
    private int _solidPower = 1000;
    public void Attack(IEnumerable<Enemy> enemiesOnAttack)
    {
        foreach (Enemy e in enemiesOnAttack)
        {
            if (e is Dragon dragon)
            {
                dragon.TakeDamage(_solidPower);
            }
        }
    }
}
