using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    public float speed = 5f; // Speed of the enemy movement
    private Rigidbody2D rb;
    private Transform player; // Reference to the player's transform
    private bool isChasing = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component attached to the enemy
    }

    // Update is called once per frame
    void Update()
    {
        if (isChasing && player != null) // Check if the enemy is chasing and the player reference is not null
        {
            // Move towards the player's position
            Vector3 direction = (player.position - transform.position).normalized; // Calculate the direction to the player
            rb.AddForce(direction * speed); // Set the enemy's velocity towards the player
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered by: " + other.name); // Log the name of the object that entered the trigger
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected!"); // Log a message when the player is detected
            if(player == null) // Check if the player reference is null
            {
                player = other.transform; // Get the player's transform when the enemy collides with the player
            }
            isChasing = true; // Start chasing the player
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player lost!"); // Log a message when the player is lost
            isChasing = false; // Stop chasing the player when they exit the trigger
        }
    }
}
