using System;
using TMPro;
using UnityEngine;

namespace ThirdHW
{
    [SelectionBase]
    public class Player : MonoBehaviour, IBuyer
    {
        public event Action OnReputationIncreased;
        public event Action OnReputationReduced;

        public int Reputation => _reputation;
        private int _reputation;

        public void IncreaseReputation()
        {
            _reputation++;
            OnReputationIncreased?.Invoke();
            
        }

        public void ReduceReputation()
        {
            _reputation--;
            OnReputationReduced?.Invoke();
        }
    }

}

