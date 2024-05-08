using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularCoin : Coin
{
    public override void Add(ICoinPicker coinPicker)
    {
        coinPicker.AddCoins(1);
    }
}
