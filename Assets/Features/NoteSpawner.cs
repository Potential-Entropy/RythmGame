using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public Lane[] lanes;
    public const float noteDelay = 0.5f;

    void spawnNote(int lane)
    {
        lanes[lane].AddNote(Time.time + noteDelay);
    }
}
