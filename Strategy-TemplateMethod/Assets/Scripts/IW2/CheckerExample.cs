using System.Collections.Generic;
using UnityEngine;

public class CheckerExample : MonoBehaviour
{
    [SerializeField] private Ork _ork;
    [SerializeField] private List<Human> _humans;

    private void Awake()
    {
        _ork.Initialize(new FrontViewBehaviour (_ork.transform, 5));

        foreach (var human in _humans)
            human.Initialize(new NoViewBehaviour());
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        //Gizmos.DrawWireSphere (_ork.transform.position, 5);

        Gizmos.DrawRay (_ork.transform.position, _ork.transform.forward * 5);
    }
}
