using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour {
  public GameObject UiEndGame;
  public GameObject UIShop;
  public GameObject UiPause;

  private void Start() {
    UiEndGame.gameObject.SetActive(false);
  }
  
  public void ShowEndGame() {
    UiEndGame.SetActive(true);
  }
  
  public void PauseGame() {
    Time.timeScale = 0;
    UiPause.SetActive(true);
  }
  
  public void ResumeGame() {
    Time.timeScale = 1;
    UiPause.SetActive(false);
  }
  
  public void BacktoHome() {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
  }
}
