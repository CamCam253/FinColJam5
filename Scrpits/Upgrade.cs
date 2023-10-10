using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Upgrade", menuName = "Upgrades/New Upgrade")]
public class Upgrade : ScriptableObject
{
    public string upgradeName = "";
    public Stats stat = new Stats();
}