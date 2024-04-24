using UnityEngine;

public class Example : MonoBehaviour
{
    [SerializeField] private SphereController _sphereController;
    [SerializeField] private GameObject _startPanel;
    [SerializeField] private GameObject _winPanel;

    private void Update()
    {
        if (_sphereController.IsWin() == true) 
        {
            _winPanel.SetActive(true);
        }
    }
    public void SetColorBehaviour()
    {
        _sphereController.SetGameMode(new PopColorBehaviour());
        _startPanel.SetActive(false);
    }
    public void SetAllBehaviour()
    {
        _sphereController.SetGameMode(new PopAllBehaviour());
        _startPanel.SetActive(false);
    }
}
