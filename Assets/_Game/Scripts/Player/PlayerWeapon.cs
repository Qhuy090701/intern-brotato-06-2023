using com.ootii.Messages;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour {
  [SerializeField] private Transform[] weaponPositions = new Transform[6];
  private List<GameObject> collectedWeapons = new List<GameObject>();
  public GameObject weaponLevel1Prefab;
  public GameObject weaponLelvel2Prefab;
  public GameObject weaponLevel3Prefab;
  private int nextAvailableWeaponIndex = 1;

  private void Start() {
    MessageDispatcher.AddListener(Constants.Mess_addWeapon, AddWeapon);

    if (weaponPositions.Length > 0 && weaponPositions[0] != null) {
      CreateWeaponAtPosition(weaponLevel1Prefab , weaponPositions[0]);
    }
  }

  public void AddWeapon(IMessage msg) {
    if (nextAvailableWeaponIndex < weaponPositions.Length && weaponPositions[nextAvailableWeaponIndex] != null) {
      CreateWeaponAtPosition(weaponLevel1Prefab , weaponPositions[nextAvailableWeaponIndex]);
      nextAvailableWeaponIndex++;
    } else {
      ShowWarningForMissingWeaponPosition();
    }
  }

  private void CreateWeaponAtPosition(GameObject weaponPrefab , Transform position) {
    GameObject newWeapon = Instantiate(weaponPrefab , position.position , position.rotation);
    newWeapon.transform.parent = position;
    collectedWeapons.Add(newWeapon);
    Debug.Log("Weapon added at position: " + position.name);
  }

  private void ShowWarningForMissingWeaponPosition() {
    Debug.LogWarning("Not enough weapon positions or position missing in weaponPositions array!");
  }
}
