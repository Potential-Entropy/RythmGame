using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    [SerializeField] int laneCount;
    private Lane[] lanes;
    public static float noteDelay = 0.5f;

    void Start()
    {
        for (int i = 0; i < laneCount; i++)
            lanes[i] = new Lane();
    }

    void SpawnNote(int lane)
    {
        // TODO fmod: play sound with delay
        lanes[lane].AddNote(new Note(noteDelay));
    }
}
