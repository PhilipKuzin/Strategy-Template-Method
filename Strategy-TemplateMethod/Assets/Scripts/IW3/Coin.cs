using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ICoinPicker coinPicker))
        {
            Debug.Log("������������� ������");
            Debug.Log("������������� ��������");

            Add(coinPicker);

            Destroy(gameObject);
        }
    }
    public abstract void Add(ICoinPicker coinPicker);
}
