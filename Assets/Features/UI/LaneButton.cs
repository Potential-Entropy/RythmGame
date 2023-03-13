using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.EventSystems;

public class LaneButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Buttons button;
    [SerializeField] private InputSystem inputSystem;

    public void OnPointerClick(PointerEventData eventData)
    {
        Trigger();
    }

    // Start is called before the first frame update
    void Start()
    {
        inputSystem[button].Subscribe(_ => Trigger()).AddTo(this);
    }

    private void Trigger()
    {
        Debug.Log(button.ToString());
    }
}
