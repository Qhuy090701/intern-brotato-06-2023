using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WeaponData {
  public WeaponInfo[] weaponInfo;

  [System.Serializable]
  public class WeaponInfo {
    public int weaponID;
    public int currentlevel;
    public float firerate;
    public int cost;
    public int damage;
    public float attackRange;
    public float attackSpeed;
    public int pierce;
    public float pierceDamageReduce;
  }
}