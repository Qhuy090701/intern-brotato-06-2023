using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayAgainButton : MonoBehaviour {
  [SerializeField] private TMP_Text textViewAds;
  [SerializeField] private int cointToRevival = 10;

  public int countClick = 2;

  private void Start() {
    LoadCoinRevival();
    GetTextBuyRevival();
  }

  private void GetTextBuyRevival() {
    textViewAds.text = "Use:" + (cointToRevival + countClick).ToString();
  }

  public void CheckCoinBuyRevival() {
    int totalCoinRiveval = countClick + cointToRevival;
    if (ReferenceHolder.Ins.playerCoin.HasEnoughCoins(totalCoinRiveval)) {
      countClick++;
      GetTextBuyRevival();
      ReferenceHolder.Ins.playerCoin.DeductCoins(totalCoinRiveval);
      SaveCoinRevival();
    } else {
      textViewAds.text = "Don't have enough money";
    }
  }

  public void LoadCoinRevival() {
    if (PlayerPrefs.HasKey(Constants.PrefsKey_CoinBuyRevival)) {
      cointToRevival = PlayerPrefs.GetInt(Constants.PrefsKey_CoinBuyRevival);
    }

    if (PlayerPrefs.HasKey(Constants.PrefsKey_ClickCountRevival)) {
      countClick = PlayerPrefs.GetInt(Constants.PrefsKey_ClickCountRevival);
    }
  }

  public void SaveCoinRevival() {
    PlayerPrefs.SetInt(Constants.PrefsKey_CoinBuyRevival, cointToRevival);
    PlayerPrefs.SetInt(Constants.PrefsKey_ClickCountRevival, countClick);
  }

  public void ResetCoinRevival() {
    countClick = 0;
    cointToRevival = 10;
    SaveCoinRevival();
  }
}