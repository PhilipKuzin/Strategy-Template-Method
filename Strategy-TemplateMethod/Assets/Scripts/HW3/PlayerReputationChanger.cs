using UnityEngine;

public class PlayerReputationChanger : MonoBehaviour
{
    private ThirdHW.Player _player;

    public void Initialize (ThirdHW.Player player)
    {
        _player = player;
    }
    public void IncreaseReputation()
    {
        _player.IncreaseReputation();
    }
    public void ReduceReputation()
    {
        _player.ReduceReputation();
    }
}
