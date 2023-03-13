using System.Collections;
using System.Collections.Generic;
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
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
    }
}
