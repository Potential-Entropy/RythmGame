using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lane : MonoBehaviour
{
    private Queue<Note> notes;
    // Start is called before the first frame update
    void Start()
    {
        notes = new Queue<Note>(50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddNote(Note note)
    {
        
    }
}
