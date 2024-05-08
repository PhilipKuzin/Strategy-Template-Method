using System.Collections.Generic;
using UnityEngine;

public class FrontFindBehaviour : IEnemyFinder
{
    private float _viewRange;
    private Transform _center;

    public FrontFindBehaviour(Transform transform, float range)
    {
        _center = transform;
        _viewRange = range;
    }
    public IEnumerable<Enemy> Find()
    {
        RaycastHit[] hited = Physics.RaycastAll(new Ray(_center.position, _center.forward), _viewRange);

        List<Enemy> result = new List<Enemy>();

        foreach (RaycastHit hit in hited)
        {
            if (hit.collider.TryGetComponent(out Enemy foundEnemy))
            {
                result.Add(foundEnemy);
            }
        }

        return result;
    }
}
