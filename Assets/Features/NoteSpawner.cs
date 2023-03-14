using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    [SerializeField] private GameObject note;
    [SerializeField] private Lane[] lanes;
    [SerializeField] private FMODUnity.EventReference[] noteSounds;
    public static float NoteDelay { get{ return GameManager.Instance.noteDelay; } }

    // for testing only
    private void Start()
    {
        SpawnNote(0, 0);
    }

    void SpawnNote(int lane, int sound)
    {
        if (lane < lanes.Length && lane >= 0 && sound >= 0 && sound < noteSounds.Length)
        {
            // for testing
            Debug.Log("Spawning Note");


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
