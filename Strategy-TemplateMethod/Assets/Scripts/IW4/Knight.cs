using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    private IKnightAttacker _attacker;
    private IEnemyFinder _enemyFinder;

    private int _currentStrenght;

    public int CurrentStrenght
    {
        get { return _currentStrenght; }
        set { _currentStrenght = value; }
    }


    private bool _isInit;

    private void Update()
    {
        if (_isInit == false)
            return;
        FindEnemies();
    }

    public void Initialize(IKnightAttacker attacker, IEnemyFinder enenemyFinder, int strenght)
    {
        _attacker = attacker;
        _enemyFinder = enenemyFinder;
        CurrentStrenght = strenght;

        _isInit = true;
    }

    public void SetAttackMode (IKnightAttacker attacker)
    {
        _attacker = attacker;
    }

    public void SetViewMode (IEnemyFinder enemyFinder)
    {
        _enemyFinder = enemyFinder;
    }

    public void IncreaseStrenght ()
    {
        CurrentStrenght++;
        Debug.Log($"Текущий показатель силы: {CurrentStrenght}");
    }

    private void FindEnemies()
    {
        IEnumerable<Enemy> findedEnemies = _enemyFinder.Find();

        _attacker.Attack(findedEnemies);
    }
}
