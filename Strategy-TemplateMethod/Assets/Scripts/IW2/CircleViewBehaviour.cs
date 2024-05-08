using System.Collections.Generic;
using UnityEngine;

public class CircleViewBehaviour : ICharacterFinder
{
    private Transform _center;
    private float _radius;

    public CircleViewBehaviour(Transform transform, float radius)
    {
        _center = transform;
        _radius = radius;
    }

    public IEnumerable<Character> Find()
    {
        Collider[] colliders = Physics.OverlapSphere(_center.position, _radius);

        List<Character> characters = new List<Character>();

        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent(out Character character))
            {
                if (character.transform != _center)
                {
                    characters.Add(character);
                }
            }
        }
        return characters;
    }
}
