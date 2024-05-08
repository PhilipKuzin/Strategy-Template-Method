using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyFinder
{
    IEnumerable<Enemy> Find();
}
