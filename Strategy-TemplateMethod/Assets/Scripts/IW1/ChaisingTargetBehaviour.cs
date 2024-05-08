using UnityEngine;

public class ChaisingTargetBehaviour : IMover
{
    private Transform _target;
    private Transform _transform;
    private float _speed;

    private bool _isMoving;

    public ChaisingTargetBehaviour(Transform transform, Transform target, float speed)
    {
        _transform = transform;
        _target = target;
        _speed = speed;
    }
    public void StartMove() => _isMoving = true;
    public void StopMove() => _isMoving = false;

    public void Update()
    {
        if (_isMoving == false)
            return;

        Vector3 direction = _target.position - _transform.position;
        _transform.Translate (direction.normalized * _speed * Time.deltaTime, Space.World);
    }
}
