using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using UnityEngine;

public class Note : MonoBehaviour
{
    public static float noteDelay = 1;
    public float timeLeft;
    public static float spawnPosition = 400;
    private static float hitPosition = 0;

    void Awake()
    {
        timeLeft = noteDelay;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        GetComponent<RectTransform>().position = 
            new Vector2(GetComponent<RectTransform>().position.x, GetComponent<RectTransform>().position.y - (spawnPosition - hitPosition) * Time.deltaTime / noteDelay);
    }
}
