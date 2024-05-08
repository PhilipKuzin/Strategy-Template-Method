using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ork : Character
{
    public override void Affect(IEnumerable<Character> findedCharacters)
    {
        Debug.Log($"Ѕью топором {findedCharacters.Count()} персонажей");
    }
}
