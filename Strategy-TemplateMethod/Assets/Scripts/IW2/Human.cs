using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Human : Character
{
    public override void Affect(IEnumerable<Character> findedCharacters)
    {
        Debug.Log($"Ѕью кулаком{findedCharacters.Count()} персонажей");
    }
}
