using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.InputSystem;

public enum Buttons
{
    Test
}

public class InputSystem : MonoBehaviour
{
    private static MainControls inputActions;

    private Dictionary<Buttons, IObservable<Unit>> istreams = new Dictionary<Buttons, IObservable<Unit>>();

    private Dictionary<Buttons, InputAction> inputMap;

    private void Awake()
    {
        inputActions = new MainControls();
        inputActions.Default.Enable();

        inputMap = new Dictionary<Buttons, InputAction>
        {
            { Buttons.Test, inputActions.Default.Debug}
        };

        foreach (var btn in inputMap.Keys)
        {
            Subject<Unit> observable = new Subject<Unit>();
            inputMap[btn].performed += _ => observable.OnNext(Unit.Default);
            istreams.Add(btn, observable);
        }
    }

    public IObservable<Unit> this[Buttons btn]
    {
        get { return istreams[btn]; }
    }
}
