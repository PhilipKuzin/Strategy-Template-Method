using UnityEngine;
public class PlayerInfoMediator : MonoBehaviour
{
    [SerializeField] private ThirdHW.Player _player;
    [SerializeField] private PlayerInfoView _playerView;

    private void OnEnable()
    {
        _player.OnReputationIncreased += ChangeReputationView;
        _player.OnReputationReduced += ChangeReputationView;
    }

    private void OnDisable()
    {
        _player.OnReputationIncreased -= ChangeReputationView;
        _player.OnReputationReduced -= ChangeReputationView;
    }

    private void ChangeReputationView()
    {
        _playerView.ShowReputation(_player.Reputation);
    }
}
