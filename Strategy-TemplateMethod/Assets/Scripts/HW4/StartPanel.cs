using System;
using UnityEngine;

public class StartPanel : MonoBehaviour
{
    public event Action OnColorModeSelected;
    public event Action OnAllModeSelected;

    public void SetColorBehaviour()
    {
        OnColorModeSelected?.Invoke();
        gameObject.SetActive(false);
    }
    public void SetAllBehaviour()
    {
        OnAllModeSelected?.Invoke();
        gameObject.SetActive(false);
    }
}
