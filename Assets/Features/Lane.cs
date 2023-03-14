using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lane : MonoBehaviour
{
    public static PlayerEnemy Player { get { return GameManager.Instance.playerManager; } }
    private Queue<Note> notes = new Queue<Note>(20);

    [SerializeField] private static float PerfectRange { get { return GameManager.Instance.pefectRange; } }
    [SerializeField] private static float GoodRange { get { return GameManager.Instance.goodRange; } }

    // Update is called once per frame
    void Update()
    {
        while (notes.Count != 0 && notes.Peek().timeLeft < -GoodRange)
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
        if (timeLeft < GoodRange)
        {
            if (timeLeft > PerfectRange)
                Player.EvaluateHit(NoteHit.Good);
            else if (timeLeft >= -PerfectRange)
                Player.EvaluateHit(NoteHit.Perfect);
            else if (timeLeft >= -GoodRange)
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
