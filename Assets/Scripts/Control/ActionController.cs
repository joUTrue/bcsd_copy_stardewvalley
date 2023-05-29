using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionController : MonoBehaviour
{
    Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        mouseClickDown();
    }

    void mouseClickDown()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)&&PlayerController.canMoving)
        {
            PlayerController.canMoving = false;
            animator.SetTrigger("PlayHoe");
        }
    }
}
