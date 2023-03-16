using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NoteTiming : MonoBehaviour
{
    [SerializeField] private Settings settingsData;

    public void SetTimingOffset()
    {
        settingsData.timingOffset = GetComponent<Slider>().value;
        settingsData.Serialize();
    }
}
