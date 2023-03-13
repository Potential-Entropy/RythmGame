using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public Lane[] lanes;
    public static float noteDelay = 0.5f;

    void spawnNote(int lane)
    {
        // fmod: play sound with delay
        lanes[lane].AddNote(new Note(Time.time + noteDelay));
    }
}
