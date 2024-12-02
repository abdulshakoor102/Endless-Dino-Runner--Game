using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Move the obstacle to the left
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        // Destroy the obstacle if it goes off-screen
        if (transform.position.x < -10f) // Adjust based on game bounds
        {
            Destroy(gameObject);
        }
    }
}
