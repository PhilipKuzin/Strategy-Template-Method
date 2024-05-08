using UnityEngine;

public class SceneChecker : MonoBehaviour
{
    [SerializeField] private Dragon _dragon;
    [SerializeField] private Knight _knight;

    private int _startStrenght = 5;

    private void Awake()
    {
        _knight.Initialize (new RegularAttackBehaviour (), new FrontFindBehaviour (_knight.transform, 10),_startStrenght);
    }

    private void Update()
    {
        if (Input.GetKeyDown (KeyCode.Q)) 
        {
            _knight.SetViewMode (new AroundFindBehaviour (_knight.transform, 10));
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            _knight.SetViewMode(new FrontFindBehaviour(_knight.transform, 10));
        }

        if (_knight.CurrentStrenght > 10)
        {
            _knight.SetAttackMode (new PowerfulAttackBehaviour ());
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        //Gizmos.DrawWireSphere (_ork.transform.position, 5);

        Gizmos.DrawRay(_knight.transform.position, _knight.transform.forward * 5);
    }

    public void IncreaseKnightStrenght()
    {
        _knight.IncreaseStrenght();
    }
}
