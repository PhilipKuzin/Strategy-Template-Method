using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCoin : Coin
{
    public override void Add(ICoinPicker coinPicker)
    {
        coinPicker.AddCoins(Random.Range (1,10));
    }
}
