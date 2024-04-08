using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public Text displayText;

    public void ShowText(string text, Color color, float duration)
    {
        StartCoroutine(DisplayTextRoutine(text, color, duration));
    }

    private IEnumerator DisplayTextRoutine(string text, Color color, float duration)
    {
        displayText.text = text;
        displayText.color = color;
        displayText.enabled = true;

        yield return new WaitForSeconds(duration);

        displayText.enabled = false;
    }
}
