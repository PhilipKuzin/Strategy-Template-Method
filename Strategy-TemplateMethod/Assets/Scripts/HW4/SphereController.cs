using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    [SerializeField] private List<GameObject> _reds = new List<GameObject>();
    [SerializeField] private List<GameObject> _whites = new List<GameObject>();
    [SerializeField] private List<GameObject> _greens = new List<GameObject>();  

    private IPlayable _mode;

    private void Update()
    {
        IsWin();
    }

    public void SetGameMode(IPlayable mode)
    {
        _mode = mode;
    }

    public bool IsWin()
    {
        if (_mode?.IsWin(_reds, _greens, _whites) == true)
        {
            return true;
        }
        return false;
    }
}


