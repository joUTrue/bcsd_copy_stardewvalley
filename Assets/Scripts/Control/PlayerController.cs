using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1f;
    public static bool canMoving = true;

    private void FixedUpdate()
    {
        if (canMoving)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0) * moveSpeed);
        }
    }

    public void SetMoveT()
    {
        canMoving = true;
    }
}

