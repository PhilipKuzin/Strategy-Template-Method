using UnityEngine;

namespace ThirdHW
{
    public class Example : MonoBehaviour
    {
        [SerializeField] private Trader _trader;
        [SerializeField] private Player _player;

        private void Awake()
        {
            _trader.SetTradeBehaviour(new NoTradeBehaviour());
        }

        private void Update()
        {
            if (_player.GetReputation() <= 3)
            {
                _trader.SetTradeBehaviour(new NoTradeBehaviour());
            }
            if (_player.GetReputation() >= 3 && _player.GetReputation() < 5)
            {
                _trader.SetTradeBehaviour(new FruitTradeBehaviour());
            }
            if (_player.GetReputation() >= 5)
            {
                _trader.SetTradeBehaviour(new ArmorTradeBehaviour());
            }
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

}
