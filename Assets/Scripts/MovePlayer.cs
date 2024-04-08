using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public RhythmChecker rhythmChecker;
    public float jumpForce = 20f; // Adjust this to set the jump force
    public float gravityScaleMultiplier = 2f; // Adjust this to control gravity
    public TextDisplay textDisplay;
    public Score score;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale *= gravityScaleMultiplier; // Apply gravity scale multiplier
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && rhythmChecker.canBePressed)
        {
            Jump();
            textDisplay.ShowText("Hit!", Color.green, 0.3f);
            score.addScore();
        }

         if (Input.GetKeyDown(KeyCode.DownArrow) && rhythmChecker.canBePressed)
        {
            Drop();
            textDisplay.ShowText("Hit!", Color.green, 0.3f);
            score.addScore();
        }

         if (Input.GetKeyDown(KeyCode.DownArrow) && !rhythmChecker.canBePressed)
        {
            textDisplay.ShowText("Miss!", Color.red, 0.3f);
            score.resetScore();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && rhythmChecker.canBePressed)
        {
            textDisplay.ShowText("Hit!", Color.green, 0.3f);
            score.addScore();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && !rhythmChecker.canBePressed)
        {
            textDisplay.ShowText("Miss!", Color.red, 0.3f);
            score.resetScore();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && !rhythmChecker.canBePressed)
        {
            textDisplay.ShowText("Miss!", Color.red, 0.3f);
            score.resetScore();
        }
    }

    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }

    void Drop()
    {
        rb.velocity = Vector2.down * jumpForce;
    }
}
