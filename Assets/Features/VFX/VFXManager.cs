using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private GameObject deflectedPrefab;

    [SerializeField] private Transform monsterPosition;
    [SerializeField] private float threshold;
    [SerializeField] private float speed;

    public void Reflect(Vector2 startPosition)
    {
        StartCoroutine(PlayAnimation(Instantiate(projectilePrefab, startPosition, Quaternion.identity, transform), monsterPosition.position));
    }

    private IEnumerator PlayAnimation(GameObject go, Vector2 target)
    {
        while (go != null && Vector2.Distance(go.transform.position, target) > threshold)
        {
            go.transform.position = Vector2.Lerp(go.transform.position, target, Time.deltaTime * speed);

            yield return null;
        }

        Destroy(go);
    }

    public void DisplayHit(NoteHit hit)
    {
        string dsiplay = hit switch
        {
            NoteHit.Miss => "Miss",
            NoteHit.Perfect => "Counter",
            NoteHit.Good => "Deflect",
            _ => throw new System.ArgumentOutOfRangeException()
        };
    }

    public void Deflect(Vector2 startPosition)
    {
        StartCoroutine(PlayAnimation(Instantiate(deflectedPrefab, startPosition, Quaternion.identity, transform), new Vector2(0, 200)));
    }
}
