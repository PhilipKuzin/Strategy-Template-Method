using System.Collections.Generic;
using UnityEngine;

public class FrontViewBehaviour : ICharacterFinder
{
    private float _viewRange;
    private Transform _center;

    public FrontViewBehaviour(Transform transform, float range)
    {
        _center = transform;
        _viewRange = range;
    }
    public IEnumerable<Character> Find()
    {
        RaycastHit[] raycastHits = Physics.RaycastAll(new Ray(_center.position, _center.forward), _viewRange);

        List<Character> characters = new List<Character>();

        foreach (RaycastHit hit in raycastHits)
            if (hit.collider.TryGetComponent(out Character character))
                if (character.transform != _center)
                    characters.Add(character);
        return characters;
    }
}
