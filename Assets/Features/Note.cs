using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using UnityEngine;

public class Note : MonoBehaviour
{
    public static float noteDelay = 0.5f;
    public float timeLeft;
    private static int spawnPosition = 0;
    private static int hitPosition = 1000;

    void Awake()
    {
        timeLeft = noteDelay;
        GetComponent<RectTransform>().anchoredPosition =
            new Vector2(GetComponent<RectTransform>().anchoredPosition.x, spawnPosition);
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        GetComponent<RectTransform>().anchoredPosition = 
            new Vector2(GetComponent<RectTransform>().anchoredPosition.x, Mathf.Lerp(hitPosition, spawnPosition, timeLeft / noteDelay));
    }
}
