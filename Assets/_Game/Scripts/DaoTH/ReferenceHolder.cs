using UnityEngine;

public class ReferenceHolder : MonoStatic<ReferenceHolder> {
  public PlayerCoin playerCoin;
  public Transform playerTran;
  public TimeManager timeManager;
  
  private void OnValidate() {
    // find and assign reference here
    if (playerCoin == null) { // example
      playerCoin = FindObjectOfType<PlayerCoin>();
      playerTran = playerCoin.gameObject.transform;
    }

    if (timeManager != null) {
      timeManager = FindObjectOfType<TimeManager>();
    }
  }
}