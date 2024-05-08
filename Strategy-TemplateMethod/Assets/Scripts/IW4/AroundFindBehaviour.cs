using System.Collections.Generic;
using UnityEngine;

public class AroundFindBehaviour : IEnemyFinder
{
    private float _radius;
    private Transform _center;

    public AroundFindBehaviour(Transform transform, float radius)
    {
        _center = transform;
        _radius = radius;
    }

    public IEnumerable<Enemy> Find()
    {
        Collider[] colliders = Physics.OverlapSphere (_center.position, _radius);

        List<Enemy> result = new List<Enemy>();

        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out Enemy enemy))
            {
                result.Add(enemy);
            }
        }
        return result;
    }
}
