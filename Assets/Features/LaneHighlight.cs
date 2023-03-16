using FMOD.Studio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LaneHighlight : MonoBehaviour
{
    private static float duration = 0.1f;
    [SerializeField] private FMODUnity.EventReference Sound;// { get { return GameManager.Instance.LaneSound; } }
    private EventInstance eventInstance;

    // Start is called before the first frame update
    void Awake()
    {
        GetComponent<CanvasRenderer>().SetAlpha(0);
        eventInstance = FMODUnity.RuntimeManager.CreateInstance(Sound);
    }

    public void Show()
    {
        StartCoroutine(ShowAndDisappear());
        eventInstance.start();
    }

    IEnumerator ShowAndDisappear()
    {
        GetComponent<CanvasRenderer>().SetAlpha(1);
        yield return new WaitForSeconds(duration);
        GetComponent<CanvasRenderer>().SetAlpha(0);

    }
}
