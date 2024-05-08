using System.Collections.Generic;
using UnityEngine;

public interface IKnightAttacker
{
    void Attack(IEnumerable <Enemy> enemiesOnAttack);
}
