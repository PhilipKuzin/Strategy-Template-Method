using UnityEngine;

namespace FourthHW
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Level _level;
        [SerializeField] private StartPanel _panel;

        private void Start()
        {
            WinBehaviourSwitcher winBehaviourSwitcher = new WinBehaviourSwitcher (_panel, _level);
        }
    }
}

