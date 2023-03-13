using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    [SerializeField] private GameObject note;
    [SerializeField] private Lane[] lanes;
    public static float noteDelay = 0.5f;

    void SpawnNote(int lane)
    {
        if (lane < lanes.Length && lane > 0)
        {
            // TODO fmod: play sound with delay
            lanes[lane].AddNote(Instantiate(note).GetComponent<Note>());
        }
        
    }
}
