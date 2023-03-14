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
        if (notes.Count != 0)
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
    }

    private void DiscardFirstNote()
    {
        if (notes.Count != 0)
            Destroy(notes.Dequeue().gameObject);
    }
}
