using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

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
            textfield.text = "";
            Debug.Log("new Text: " + index + ", text max: " + texts.Length);
            for (int i = 0; i < texts[index].Length; i++)
            {
                textfield.text = string.Concat(textfield.text, texts[index][i]);
                //Wait a certain amount of time, then continue with the for loop
                yield return new WaitForSeconds(timer);
            }
            Debug.Log("Text done: " + index);
            yield return new WaitUntil(() => Input.GetMouseButton(0));
            yield return new WaitUntil(() => Input.GetMouseButtonUp(0));
        }
        SceneManager.LoadScene(2);
    }

}
