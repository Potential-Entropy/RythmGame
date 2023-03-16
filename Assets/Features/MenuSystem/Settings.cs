using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SettingData", menuName = "ScriptableObjects/SettingScriptableObject", order = 1)]
public class Settings : ScriptableObject
{
    public float timingOffset;
    public bool terribleMode;
}
