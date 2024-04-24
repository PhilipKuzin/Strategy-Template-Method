using System.Collections.Generic;
using UnityEngine;

public interface IPlayable
{
    bool IsWin(List<GameObject> reds, List<GameObject> greens, List<GameObject> whites);
}
