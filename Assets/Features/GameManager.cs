using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
        NoteSpawnPosition = NoteSpawn.transform.position.y;
        NoteHitPosition = NoteHit.transform.position.y;
    }

    public PlayerEnemy playerManager;

    public float noteDelay;

    public GameObject NoteSpawn;
    public GameObject NoteHit;
    public float NoteSpawnPosition;
    public float NoteHitPosition;
}
