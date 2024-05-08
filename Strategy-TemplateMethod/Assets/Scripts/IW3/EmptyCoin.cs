using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyCoin : Coin
{
    public override void Add(ICoinPicker coinPicker)
    {
        coinPicker.AddCoins(0);
    }
}
