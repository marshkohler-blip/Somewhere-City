using UnityEngine;

public class Note : MonoBehaviour
{
    // Speed the note falls
    public float fallSpeed = 5f;

    void Update()
    {
        // Move note downward every frame
        transform.position += Vector3.down * fallSpeed * Time.deltaTime;

        // Destroy note if it goes off screen (cleanup)
        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }
}