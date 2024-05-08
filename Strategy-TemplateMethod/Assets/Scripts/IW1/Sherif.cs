using UnityEngine;

public class Sherif : MonoBehaviour
{
    [SerializeField] private float _speed;
    private IMover _mover;

    public float Speed => _speed;

    private void Update()
    {
        _mover.Update();
    }

    public void SetMover (IMover mover)
    {
        _mover?.StopMove();
        _mover = mover;
        _mover.StartMove();
    }
}
