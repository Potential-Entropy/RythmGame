using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SongScriptableObject", order = 1)]
public class Song : ScriptableObject
{
    [Header("Songfile")]
    public FMODUnity.EventReference song;

    [Header("Notes Info")]
    public float bpm = 130f;
    [Header("X: Beat, Y: Lane Index, Z: Sound")]
    public Vector3[] noteInfos;
}
