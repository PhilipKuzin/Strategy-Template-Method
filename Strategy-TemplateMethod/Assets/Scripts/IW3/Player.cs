using System;
using UnityEngine;

namespace IW_3
{
    public class Player : MonoBehaviour, ICoinPicker
    {
        public int Coins { get; private set; }

        public void AddCoins(int value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
            Coins += value;
            Debug.Log(Coins);
        }
    }
}

