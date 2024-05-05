using TMPro;
using UnityEngine;

namespace ThirdHW
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private TMP_Text _reputationIndex;
        private int _reputation;

        public void IncreaseReputation()
        {
            _reputation++;
            ShowReputation();
        }
        public void ReduceReputation()
        {
            _reputation--;
            ShowReputation();
        }
        public int GetReputation()
        {
            return _reputation;
        }
        private void ShowReputation()
        {
            _reputationIndex.text = _reputation.ToString();
        }

    }

}

