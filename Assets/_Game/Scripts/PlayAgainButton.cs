using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayAgainButton : MonoBehaviour {
    [SerializeField] private TMP_Text textViewAds;
    [SerializeField] private int cointToRevival = 10;
    [SerializeField] private int countClick;
    
    private void Start() {
        LoadCoinRevival();
        GetTextBuyRevival();
    }
    
    private void GetTextBuyRevival() {
        textViewAds.text = "Use:" + (cointToRevival + countClick).ToString();
    }
    
    public void CheckCoinBuyRevival() {
        ReferenceHolder.Ins.player.coinAmount -= (cointToRevival + countClick);
        ReferenceHolder.Ins.playerUi.GetTextCoin();
        countClick++;
        GetTextBuyRevival();
        SaveCoinRevival();
    }

    public void LoadCoinRevival() {
        if (PlayerPrefs.HasKey(Constants.PrefsKey_CoinBuyRevival)) {
            countClick = PlayerPrefs.GetInt(Constants.PrefsKey_CoinBuyRevival);
        }
    }
    
    public void SaveCoinRevival() {
        PlayerPrefs.SetInt(Constants.PrefsKey_CoinBuyRevival, countClick);
    }
     public void ResetCoinRevival() {
         countClick = 0;
         SaveCoinRevival();
     }
}
