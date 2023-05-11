using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1f;
    public static bool canMoving = true;
        // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        
     
    }
    private void FixedUpdate()
    {
        if (canMoving)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0) * moveSpeed);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {

        }
    }
}

