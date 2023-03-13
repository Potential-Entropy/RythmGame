using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using UnityEngine;

public class Note : MonoBehaviour
{
    public static float noteDelay = 0.5f;
    public float timeLeft;
    [SerializeField] private FMODUnity.EventReference testSound;
    private static int spawnPosition = 0;
    private static int hitPosition = 1000;
    private EventInstance instance;

    void Awake()
    {
        timeLeft = noteDelay;
        instance = FMODUnity.RuntimeManager.CreateInstance(testSound);
        StartCoroutine(PlayNote());
        GetComponent<RectTransform>().anchoredPosition =
            new Vector2(GetComponent<RectTransform>().anchoredPosition.x, spawnPosition);
    }

    IEnumerator PlayNote()
    {
        yield return new WaitForSeconds(noteDelay);
        instance.start();
        instance.release();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        GetComponent<RectTransform>().anchoredPosition = 
            new Vector2(GetComponent<RectTransform>().anchoredPosition.x, Mathf.Lerp(hitPosition, spawnPosition, timeLeft / noteDelay));
    }
}
