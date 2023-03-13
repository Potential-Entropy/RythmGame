using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class InputTest : MonoBehaviour
{

    [SerializeField] private InputSystem inputSystem;
    private void Start()
    {
        inputSystem[Buttons.Test].Subscribe(_ => Debug.Log("Pressed")).AddTo(this);
    }
}
