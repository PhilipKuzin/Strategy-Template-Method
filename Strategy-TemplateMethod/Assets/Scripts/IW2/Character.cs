using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private ICharacterFinder _characterFinder;
    private bool _isInit;

    public void Initialize (ICharacterFinder characterFinder)
    {
        _characterFinder = characterFinder;
        _isInit = true;
    }

    private void Update ()
    {
        if (_isInit == false)                                           // защита при отсутствии инициализации 
            throw new InvalidOperationException(nameof(_isInit));
        
        IEnumerable<Character> findedCharacters = _characterFinder.Find();

        if (findedCharacters != null )
        {
            Affect(findedCharacters);
        }
    }

    public abstract void Affect(IEnumerable<Character> findedCharacters);
}
