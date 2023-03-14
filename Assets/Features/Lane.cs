using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lane : MonoBehaviour
{
    public static PlayerEnemy Player { get { return GameManager.Instance.playerManager; } }
    private Queue<Note> notes = new Queue<Note>(20);

    [SerializeField] private const float perfectRange = 0.05f;
    [SerializeField] private const float goodRange = 0.1f;

    // Update is called once per frame
    void Update()
    {
        while (notes.Count != 0 && notes.Peek().timeLeft < -goodRange)
        {
            DiscardFirstNote();
            Player.EvaluateHit(NoteHit.Miss);
        }
    }

    public void AddNote(GameObject notePrefab)
    {
        Note note = Instantiate(notePrefab, new Vector2(0, GameManager.Instance.NoteSpawnPosition), Quaternion.identity, transform).GetComponent<Note>();
        notes.Enqueue(note);

        // for testing
        //note.transform.position = new Vector2(spawnX, spawnY);
    }

    public void Hit()
    {
        float timeLeft = notes.Peek().timeLeft;
        if (timeLeft < goodRange)
        {
            if (timeLeft > perfectRange)
                Player.EvaluateHit(NoteHit.Good);
            else if (timeLeft >= -perfectRange)
                Player.EvaluateHit(NoteHit.Perfect);
            else if (timeLeft >= -goodRange)
                Player.EvaluateHit(NoteHit.Good);
            else
                Player.EvaluateHit(NoteHit.Miss);

            DiscardFirstNote();
        }
    }

    private void DiscardFirstNote()
    {
        Destroy(notes.Dequeue().gameObject);
    }
}
