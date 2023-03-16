using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ModeToggle : MonoBehaviour
{
    [SerializeField] private Settings settingsData;
    public void SetMode()
    {
        settingsData.terribleMode = GetComponent<Toggle>().isOn;
        settingsData.Serialize();
    }
}
