using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {
  public Transform player;
  [SerializeField] private Transform[] weaponPoint;

  private void Awake() {
    foreach (Transform weapon in weaponPoint) {
      if (weaponPoint[0]) {
        weaponPoint[0].position = new Vector3(player.transform.position.x, player.transform.position.y + 3f, 0f);
      } 
      
      if (weaponPoint[1]) {
        weaponPoint[1].position = new Vector3(-3, player.transform.position.y + 1.5f, 0f);
      }
      
      if (weaponPoint[2]) {
        weaponPoint[2].position = new Vector3(3, player.transform.position.y + 1.5f, 0f);
      }
      
      if (weaponPoint[3]) {
        weaponPoint[3].position = new Vector3(-3, player.transform.position.y -1.5f, 0f);
      }
      
      if (weaponPoint[4]) {
        weaponPoint[4].position = new Vector3(3, player.transform.position.y -1.5f, 0f);
      }
      
      if (weaponPoint[5]) {
        weaponPoint[5].position = new Vector3(player.transform.position.x, player.transform.position.y - 3f, 0f);
      }
    }
  }

  private void Update() {
    FollowPlayer();
  }

  private void FollowPlayer() {
    if (player != null) {
      transform.position = player.position;
    }
  }
}
