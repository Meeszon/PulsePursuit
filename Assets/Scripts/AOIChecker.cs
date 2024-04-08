using UnityEngine;

public class AOIChecker : MonoBehaviour
{
    
    // Function to check if the line intersects with the Collider of this object
    public bool IsLineIntersecting(Collider2D lineCollider)
    {
        // Check if the line's Collider intersects with this object's Collider
        return GetComponent<Collider2D>().IsTouching(lineCollider);
    }
}

