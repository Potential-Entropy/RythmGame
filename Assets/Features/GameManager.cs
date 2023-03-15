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
        NoteSpawnPosition = NoteSpawn.GetComponent<RectTransform>().position.y;
        NoteHitPosition = NoteHit.GetComponent<RectTransform>().position.y;
    }

    public PlayerEnemy playerManager;

    public float noteDelay;

    public GameObject NoteSpawn;
    public GameObject NoteHit;
    public float NoteSpawnPosition;
    public float NoteHitPosition;

    public float pefectRange = 0.05f;
    public float goodRange = 0.1f;

    public GameObject LanePanel;

    public VFXManager VFXManager;
}
