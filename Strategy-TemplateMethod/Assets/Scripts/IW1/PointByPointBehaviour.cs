using System.Collections.Generic;
using UnityEngine;

public class PointByPointBehaviour : IMover
{
    private Transform _transform;
    private Queue<Vector3> _targets;
    private float _speed;
    private Vector3 _currentTarget;

    private bool _isMoving;

    private const float MinDistanceToTarget = 3f;

    public PointByPointBehaviour(Transform transform, IEnumerable <Vector3> targets, float speed)
    {
        _transform = transform;
        _targets = new Queue <Vector3> (targets); // ������� ����� �������, ����� �������� ����������� ��������� ������� (�.� �������� �� ������)
        _speed = speed;

        _currentTarget = _targets.Dequeue(); // ����������� ������� ���� ������ ������� �������
        Debug.Log("����������� ���������");
    }

    public void StartMove () => _isMoving = true;
    public void StopMove () => _isMoving = false;

    public void Update ()
    {
        if (_isMoving == false)
            return;

        Vector3 direction = _currentTarget - _transform.position;   // ������ ����������� ��������
        _transform.Translate (direction.normalized * _speed * Time.deltaTime, Space.World); // ���������
        Debug.Log("���������");

        if (direction.magnitude <= MinDistanceToTarget) // ���� ������� ������� ������ - ������ ���� 
        {
            SwitchTarget();
        }
    }

    private void SwitchTarget ()
    {
        _targets.Enqueue(_currentTarget); // ��������� ������� ���� � ����� �������
        _currentTarget = _targets.Dequeue();
        Debug.Log("������������ ���� ����������");
    }
}
