using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayAgainButton : MonoBehaviour {
    [SerializeField] private TMP_Text textViewAds;
    [SerializeField] private int cointToRevival = 10;
    [SerializeField] private int countClick;
    
    private void Start() {
        countClick = 1;
        GetTextBuyRevival();
    }
    
    private void GetTextBuyRevival() {
        textViewAds.text = "Use:" + (cointToRevival * countClick).ToString();
    }
    
    public void CheckCoinBuyRevival() {
        //FIND BUG HERRE TOMORROW.
        ReferenceHolder.Ins.player.coinAmount -= (cointToRevival * countClick);
        ReferenceHolder.Ins.playerUi.GetTextCoin();
        countClick++;
        GetTextBuyRevival();
    }
}
