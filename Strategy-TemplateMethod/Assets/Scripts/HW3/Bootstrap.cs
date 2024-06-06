using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private ThirdHW.Player _player;
    [SerializeField] private ThirdHW.Trader _trader;
    private PlayerReputationChanger _playerReputationChanger;

    private void Start()
    {
        TradeBehaviourSwitcher tradeBehaviourSwitcher = new TradeBehaviourSwitcher(_trader, _player);
        _playerReputationChanger = _player.GetComponent<PlayerReputationChanger>();
        _playerReputationChanger.Initialize(_player);     
    }
}
