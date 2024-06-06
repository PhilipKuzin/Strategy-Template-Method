using System;
using UnityEngine;

public class TraderInfoMediator : MonoBehaviour
{
    [SerializeField] private ThirdHW.Trader _trader;
    [SerializeField] private TraderInfoView _traderView;

    private void OnEnable()
    {
        _trader.OnTrade += ShowTradeSpeech;
    }

    private void OnDisable()
    {
        _trader.OnTrade -= ShowTradeSpeech;
    }

    private void ShowTradeSpeech()
    {
        _traderView.TadeSpeech.text = _trader.TraderStrategy.Trade();
    }

}
