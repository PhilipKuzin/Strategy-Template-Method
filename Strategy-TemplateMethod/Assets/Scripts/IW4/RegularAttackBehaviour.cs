using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularAttackBehaviour : IKnightAttacker
{
    private int _regularPower = 10;

    public void Attack(IEnumerable<Enemy> enemiesOnAttack)
    {
        foreach (Enemy e in enemiesOnAttack)
        {
            if (e is Dragon dragon)
            {
                dragon.TakeDamage(_regularPower);
            }
        }
    }
}
