using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{

    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // FixedUpdate is called every fixed framerate frame, if the MonoBehaviour is enabled
    void FixedUpdate()
    {
        InputAction attack1Side = InputSystem.actions.FindAction("Attack1Side");
        InputAction attack1Up = InputSystem.actions.FindAction("Attack1Up");
        InputAction attack1Down = InputSystem.actions.FindAction("Attack1Down");
        if (attack1Side.IsPressed() && !attack1Up.IsPressed() && !attack1Down.IsPressed())
        {

            animator.SetBool("onAttack1Side", true);
        }
        else if (attack1Up.IsPressed())
        {
            animator.SetBool("onAttack1Up", true);
        }
        else if (attack1Down.IsPressed())
        {
            animator.SetBool("onAttack1Down", true);
        }
    }

    public void EndAttack()
    {
        animator.SetBool("onAttack1Side", false);
        animator.SetBool("onAttack1Up", false);
        animator.SetBool("onAttack1Down", false);
    }
}
