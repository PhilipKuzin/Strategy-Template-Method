using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PopAllBehaviour : IPlayable
{
    public bool IsWin(List<GameObject> reds,  List<GameObject> greens, List<GameObject> whites)
    {
       if (reds.All(obj => obj == null) && greens.All(obj => obj == null) && whites.All(obj => obj == null))
            return true;
       return false;
    }
}
