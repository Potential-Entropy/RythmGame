using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class TextDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textfield;
    [SerializeField] private float timer;
    [SerializeField] private string[] texts;


    void Start()
    {
        textfield.text = "";
        if (texts.Length > 0)
            StartCoroutine(BuildText());
    }

    private void Update()
    {

    }

    private IEnumerator BuildText()
    {
        for (int index = 0; index < texts.Length; index++)
        {
            for (int i = 0; i < texts[index].Length; i++)
            {
                textfield.text = string.Concat(textfield.text, texts[index][i]);
                //Wait a certain amount of time, then continue with the for loop
                yield return new WaitForSeconds(timer);
            }
            yield return new WaitUntil(() => Input.GetMouseButton(0));
            yield return new WaitUntil(() => Input.GetMouseButtonUp(0));
        }      
    }

}
