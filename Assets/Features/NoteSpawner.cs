using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using UnityEngine;


public class NoteSpawner : MonoBehaviour
{
    [SerializeField] private GameObject note;
    [SerializeField] private Lane[] lanes;
    [SerializeField] private FMODUnity.EventReference[] noteSounds;

    private Vector3[] noteInfos;
    private FMODUnity.EventReference songF;
    private PLAYBACK_STATE state;
    private EventInstance songInstance;

    private float bps;
    private float timePassed = 0f;
    private bool started = false;
    private int noteIndex = 0;
    
    public static float NoteDelay = 1f;

    public Song songObject;


    private void Awake()
    {
        float laneWidth = 1.0f * Screen.width / lanes.Length;
        for(int i = 0; i < lanes.Length; i++)
        {
            lanes[i].xPosition = (i + 0.5f) * laneWidth;
        }
    }

    private void Start()
    {
        //StartMusic();
        bps = songObject.bpm / 60f;
        noteInfos = songObject.noteInfos;
        songF = songObject.song;

    }

    private void Update()
    {
        if (!started)
        {
            songInstance = FMODUnity.RuntimeManager.CreateInstance(songF);
            StartMusic();
        }        

        songInstance.getPlaybackState(out state);
        if (state == PLAYBACK_STATE.STOPPING || state == PLAYBACK_STATE.STOPPED)
            StartMusic();

        timePassed += Time.deltaTime;

        var currentNote = noteIndex < noteInfos.Length ? noteInfos[noteIndex] : Vector3.zero;
        if (noteIndex < noteInfos.Length && (currentNote.x / bps - NoteDelay) <= timePassed)
        {
            SpawnNote((int)currentNote.y, (int)currentNote.z);
            ++noteIndex;
        }
    }

    void StartMusic()
    {
        // Resetting
        timePassed = 0;
        noteIndex = 0;

        // Playing the Song
        songInstance.start();

        started = true;
    }

    void SpawnNote(int lane, int sound)
    {
        if (lane < lanes.Length && lane >= 0 && sound >= 0 && sound < noteSounds.Length)
        {
            lanes[lane].AddNote(note);
            //StartCoroutine(PlayNote(FMODUnity.RuntimeManager.CreateInstance(noteSounds[sound])));
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
