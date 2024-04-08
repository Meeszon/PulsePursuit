using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 5f; // Adjust speed as needed
    public Direction direction = Direction.Right; // Default direction
    private Renderer objectRenderer;

    public enum Direction
    {
        Right,
        Left
    }


    private void Start()
    {
        // Get the Renderer component
        objectRenderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        // Move the object according to the specified direction
        if (direction == Direction.Right)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if (direction == Direction.Left)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RhythmLine"))
        {
            Renderer rhythmLineRenderer = collision.gameObject.GetComponent<Renderer>();
            rhythmLineRenderer.enabled = false;
            objectRenderer.enabled = false;
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Activator"))
        {
            Destroy(gameObject);
        }
    }
}
