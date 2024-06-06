using UnityEngine;
using TMPro;
using System;

namespace ThirdHW
{
    public class Trader : MonoBehaviour
    {
        [SerializeField] private TMP_Text _tradeSpeech;

        public event Action OnTrade;
        public ITrader TraderStrategy { get; private set; }
        private float _tradeRadius = 2f;

        private void Update()
        {
            CheckForTrade();
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, _tradeRadius);
        }

        public void SetTradeBehaviour(ITrader tradeBeh)
        {
            TraderStrategy = tradeBeh;
        }

        private void CheckForTrade()
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, _tradeRadius);

            foreach (Collider collider in colliders)
            {
                if (collider.TryGetComponent(out IBuyer player))
                    OnTrade?.Invoke();
            }
        }
    }
}


