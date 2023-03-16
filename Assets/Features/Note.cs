using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using UnityEngine;

public class Note : MonoBehaviour
{
    public static float NoteDelay { get { return GameManager.Instance.noteDelay; } }

    public float timeLeft;
    private static float spawnPosition { get { return GameManager.Instance.NoteSpawnPosition; } }
    private static float hitPosition { get { return GameManager.Instance.NoteHitPosition; } }


    void Awake()
    {
        timeLeft = NoteDelay - GameManager.Instance.settingsData.timingOffset;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        RectTransform rt = GetComponent<RectTransform>();
        rt.position = new Vector2(rt.position.x, hitPosition + (spawnPosition - hitPosition) * timeLeft / NoteDelay);
    }
}
