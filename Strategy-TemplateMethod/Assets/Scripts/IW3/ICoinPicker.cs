using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICoinPicker 
{
    int Coins { get; }

    void AddCoins(int value);
}
