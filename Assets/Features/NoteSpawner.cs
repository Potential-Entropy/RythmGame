using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public Lane[] lanes;
    public static const float noteDelay = 0.5f;

    void spawnNote(int lane)
    {

        lanes[lane].AddNote(note);
    }
}
