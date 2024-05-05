using UnityEngine;
using TMPro;

namespace ThirdHW
{
    public class Trader : MonoBehaviour
    {
        [SerializeField] private TMP_Text _tradeSpeech;
        private ITrader _trader;
        private float _tradeRadius = 2f;
       
        private void Update()
        {
            CheckForTrade();
        }

        public void SetTradeBehaviour(ITrader tradeBeh)
        {
            _trader = tradeBeh;
        }

        private void CheckForTrade()
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, _tradeRadius);
            
            foreach (Collider collider in colliders)
            {
                if (collider.TryGetComponent(out Player player))
                    _tradeSpeech.text = _trader.Trade();
            }
        }
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere (transform.position, _tradeRadius);
        }
    }
}


