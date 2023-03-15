using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.UIElements;

public class LaneHighlight : MonoBehaviour
{
    private static float duration = 0.1f;
    // Start is called before the first frame update
    void Awake()
    {
        GetComponent<CanvasRenderer>().SetAlpha(0);
    }

    public void Show()
    {
        StartCoroutine(ShowAndDisappear());
    }

    IEnumerator ShowAndDisappear()
    {
        GetComponent<CanvasRenderer>().SetAlpha(1);
        yield return new WaitForSeconds(duration);
        GetComponent<CanvasRenderer>().SetAlpha(0);

    }
}
