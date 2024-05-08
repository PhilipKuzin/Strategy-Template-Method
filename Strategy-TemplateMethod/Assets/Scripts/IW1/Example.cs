using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace IW_1
{
    public class Example : MonoBehaviour
    {
        [SerializeField] private Sherif _sherif;
        [SerializeField] private Transform _target;
        [SerializeField] private List<Transform> _pointsForPatrol;

        private void Awake()
        {
            _sherif.SetMover(new NoMoveBehaviour());
        }

        private void Update()
        {
            if (Input.GetKey (KeyCode.Q))
            {
                _sherif.SetMover(new PointByPointBehaviour(_sherif.transform, _pointsForPatrol.Select(p => p.position), _sherif.Speed));
            }
            if (Input.GetKey(KeyCode.W))
            {
                _sherif.SetMover(new ChaisingTargetBehaviour(_sherif.transform, _target, _sherif.Speed));
            }
            if (Input.GetKey(KeyCode.E))
            {
                _sherif.SetMover(new NoMoveBehaviour());
            }
        }
    }
}


