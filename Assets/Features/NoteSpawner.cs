using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using UnityEngine;


public class NoteSpawner : MonoBehaviour
{
    [SerializeField] private GameObject note;
    [SerializeField] private Lane[] lanes;
    [SerializeField] private FMODUnity.EventReference[] noteSounds;

    [SerializeField] private float bpm = 130f;

    /*[Header("Level Design Notes")]
    [SerializeField] private int[] noteBeats;
    [SerializeField] private int[] noteLaneRef;
    [SerializeField] private int[] noteSoundRef;*/

    [Header("X: Beat, Y: Lane Index, Z: Sound")]
    [SerializeField] private Vector3Int[] noteInfos;

    private float bps;
    float startTime;
    float timePassed = 0f;
    bool started = false;
    int noteIndex = 0;

    public static float NoteDelay = 1f;

    private void Awake()
    {
        float laneWidth = 1.0f * Screen.width / lanes.Length;
        for(int i = 0; i < lanes.Length; i++)
        {
            lanes[i].xPosition = (i + 0.5f) * laneWidth;
        }
    }
    // for testing only
    private void Start()
    {
        bps = bpm / 60f;
        SpawnNote(2, 0);
        StartMusic();
    }

    private void Update()
    {
        if (!started) return;

        timePassed = Time.time - startTime;
        float pointInMusic = timePassed * bps;
        Vector3Int currentNote = noteIndex < noteInfos.Length ? noteInfos[noteIndex] : Vector3Int.zero;

        if (noteIndex < noteInfos.Length && (currentNote.x / bps) <= pointInMusic)
        {
            Debug.Log("Time passed: " + timePassed);
            //SpawnNote(noteIndex < noteLaneRef.Length ? noteLaneRef[noteIndex] : 0, noteIndex < noteSoundRef.Length ? noteSoundRef[noteIndex] : 0);

            SpawnNote(currentNote.y, currentNote.z);

            ++noteIndex;
        }
    }

    void StartMusic()
    {
        startTime = Time.time;
        noteIndex = 0;
        started = true;
    }

    void SpawnNote(int lane, int sound)
    {
        if (lane < lanes.Length && lane >= 0 && sound >= 0 && sound < noteSounds.Length)
        {
            lanes[lane].AddNote(note);
            StartCoroutine(PlayNote(FMODUnity.RuntimeManager.CreateInstance(noteSounds[sound])));
        }
        else
        {
            Debug.Log("Invalid SpawnNote parameter");
        }
    }
    
    IEnumerator PlayNote(EventInstance instance)
    {
        yield return new WaitForSeconds(NoteDelay);
        instance.start();
        instance.release();
    }
}
