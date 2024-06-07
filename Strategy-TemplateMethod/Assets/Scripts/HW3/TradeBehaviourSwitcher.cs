using ThirdHW;

public class TradeBehaviourSwitcher 
{
    private const int NOTRADE_TRESHOLD = 3;
    private const int FRUITTRADE_TRESHOLD = 5;
    private const int ARMORTRADE_TRESHOLD = 6;
    private Trader _trader;
    private ThirdHW.Player _player;

    public TradeBehaviourSwitcher(Trader trader, ThirdHW.Player player)
    {
        _trader = trader;
        _player = player;

        _trader.SetTradeBehaviour(new NoTradeBehaviour());
        _player.OnReputationChanged += SwitchBehaviour;
        // необходимо оформить отписку IDisposable Zenject ? 
    }

    public void SwitchBehaviour()
    {
        if (_player.Reputation <= NOTRADE_TRESHOLD)
        {
            _trader.SetTradeBehaviour(new NoTradeBehaviour());
            return;
        }
        if (_player.Reputation >= NOTRADE_TRESHOLD && _player.Reputation <= FRUITTRADE_TRESHOLD)
        {
            _trader.SetTradeBehaviour(new FruitTradeBehaviour());
            return;
        }
        if (_player.Reputation >= ARMORTRADE_TRESHOLD)
        {
            _trader.SetTradeBehaviour(new ArmorTradeBehaviour());
            return;
        }
    }
}
