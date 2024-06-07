using System;
using UnityEngine;

public class WinPanelMediator : MonoBehaviour
{
    [SerializeField] private Level _level;
    [SerializeField] private WinPanel _winPanel;

    private void OnEnable()
    {
        _level.LevelWon += ShowWinPanel;
    }
    private void OnDisable()
    {
        _level.LevelWon -= ShowWinPanel;
    }

    private void ShowWinPanel()
    {
        _winPanel.Show();
    }
}
