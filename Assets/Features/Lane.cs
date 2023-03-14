using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lane : MonoBehaviour
{
    public static PlayerEnemy player;
    private Queue<Note> notes;

    [SerializeField] private const float perfectRange = 0.05f;
    [SerializeField] private const float goodRange = 0.1f;
    [SerializeField] private float spawnX = 0;
    [SerializeField] private static float spawnY = 2.35f;

    // Start is called before the first frame update
    void Start()
    {
        notes = new Queue<Note>(20); // <- Wie viele Noten können höchstens gleichzeitig pro Lane existieren
    }

    // Update is called once per frame
    void Update()
    {
        while (notes.Peek().timeLeft < - goodRange)
        {
            notes.Dequeue();
            player.EvaluateHit(NoteHit.Miss);
        }
    }

    public void AddNote(Note note)
    {
        notes.Enqueue(note);

        // for testing
        note.transform.position = new Vector2(spawnX, spawnY);
    }

    public void Hit()
    {
        float timeLeft = notes.Peek().timeLeft;
        if (timeLeft < goodRange)
        {
            if(timeLeft > perfectRange)
                player.EvaluateHit(NoteHit.Good);
            else if(timeLeft >= -perfectRange)
                player.EvaluateHit(NoteHit.Perfect);
            else if(timeLeft >= -goodRange)
                player.EvaluateHit(NoteHit.Good);
            else
                player.EvaluateHit(NoteHit.Miss);
        }
        notes.Dequeue();
    }
}
