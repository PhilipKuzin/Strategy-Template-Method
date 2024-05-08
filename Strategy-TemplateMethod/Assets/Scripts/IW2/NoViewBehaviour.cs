using System.Collections.Generic;

public class NoViewBehaviour : ICharacterFinder
{
    public IEnumerable<Character> Find()
    {
        return null;
    }
}
