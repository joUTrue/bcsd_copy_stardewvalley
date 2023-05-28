using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{

    Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(PlayerController.canMoving)
        {
            animator.SetFloat("Vertical", Input.GetAxisRaw("Vertical"));
            animator.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));
            if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
            {
                animator.SetFloat("Stand_H", Input.GetAxisRaw("Horizontal"));
                animator.SetFloat("Stand_V", Input.GetAxisRaw("Vertical"));
            }

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                animator.SetTrigger("Play");
            }
        }
    }
}
