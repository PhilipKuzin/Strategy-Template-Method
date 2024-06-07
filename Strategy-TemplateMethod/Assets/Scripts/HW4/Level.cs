using System;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] public List<Sphere> _spheres = new List<Sphere>();
    public event Action LevelWon;
    public IVictoryCondition Mode { get; private set; }

    private void Update()
    {
        IsWin();
    }

    public void SetGameMode(IVictoryCondition mode)
    {
        Mode = mode;
        Debug.Log($"Применен {mode}");
    }

    public void IsWin()
    {
        if (Mode?.IsWin(_spheres) == true)
            LevelWon?.Invoke();
    }
}


