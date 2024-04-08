using UnityEngine;

public class RhythmChecker : MonoBehaviour
{
    public bool canBePressed;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "RhythmLine")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "RhythmLine")
        {
            canBePressed = false;
        }
    }
}
