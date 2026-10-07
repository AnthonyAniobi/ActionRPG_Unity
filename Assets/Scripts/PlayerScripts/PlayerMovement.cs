using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    private Animator animator;
    private Rigidbody2D rigidBody;
    private float facingDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();
        facingDirection = transform.localScale.x;
    }

    // FixedUpdate is called every fixed framerate frame, if the MonoBehaviour is enabled
    void FixedUpdate()
    {
        InputAction move = InputSystem.actions.FindAction("Move");
        
        Vector2 movement = move.ReadValue<Vector2>();
        if(movement.x != 0 || movement.y != 0)
        {
            // set movey animation value
            if (movement.x > 0 && facingDirection < 0 || movement.x < 0 && facingDirection > 0)
            {
                facingDirection *= -1;
                Vector3 newScale = transform.localScale;
                newScale.x = facingDirection;
                transform.localScale = newScale;
            }
            animator.SetBool("isRunning", true);
            rigidBody.linearVelocity = movement * moveSpeed;
        }
        else
        {
            animator.SetBool("isRunning", false);
            rigidBody.linearVelocity = Vector2.zero;
        }
    }
}
