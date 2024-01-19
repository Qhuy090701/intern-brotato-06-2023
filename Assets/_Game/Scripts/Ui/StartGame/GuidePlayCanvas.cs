using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GuidePlayCanvas : MonoBehaviour
{
	[SerializeField] private GameObject guidePlayCanvas;
	[SerializeField] private TextMeshProUGUI titleTextGuildPlay;
	[SerializeField] private TextMeshProUGUI contentTextGuildPlay;
	private int indexGuildPlay;
	private void Update() {
		if(indexGuildPlay == 0) {
			titleTextGuildPlay.text = "How to Move";
			contentTextGuildPlay.text = "Use the joystick to move the character";
		} else if (indexGuildPlay == 1) {
			titleTextGuildPlay.text = "How to Attack";
			contentTextGuildPlay.text = "Buy weapons in the shop and use them to attack enemies";
		} else if (indexGuildPlay == 2) {
			titleTextGuildPlay.text = "Buy item";
			contentTextGuildPlay.text = "Buy items in the shop to increase your character's stats";
		} else if (indexGuildPlay == 3) {
			titleTextGuildPlay.text = "How to Win";
			contentTextGuildPlay.text = "Kill all enemies to win";
		}
	}

	public void ButtonNextClick() {
		CheckValueIndex();
		indexGuildPlay--;
		
	}

	public void ButtonPrevClick() {
		CheckValueIndex();
		indexGuildPlay++;
	}

	public void CheckValueIndex() {
		if (indexGuildPlay < 0) {
			indexGuildPlay = 0;
		} else if (indexGuildPlay > 3) {
			indexGuildPlay = 3;
		}
	}
}
