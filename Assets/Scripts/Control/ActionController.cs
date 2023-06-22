using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionController : MonoBehaviour
{
    private Animator animator;
    [SerializeField]private Inventory inventory;
    [SerializeField]private TilemapManager tilemapManager;
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
            tilemapManager.GetTile(gameObject.transform.position);
        }
    }
}
