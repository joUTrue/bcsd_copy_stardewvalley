using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    public List<GameObject> canClickList = new List<GameObject>();
    public ScriptManager scriptManager;
    RaycastHit2D hit;
    bool isActive = false;



    void Update()
    {
        MouseClickDown();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!canClickList.Contains(collision.gameObject))
        {
            canClickList.Add(collision.gameObject);
            Debug.Log(collision.gameObject.name + " enter");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (canClickList.Contains(collision.gameObject))
        {
            canClickList.Remove(collision.gameObject);
            Debug.Log(collision.gameObject.name + " exit");
        }
    }

    void MouseClickDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            BoolOnonSelected();
        }
    }

    void BoolOnonSelected()
    {
        if (scriptManager.isVisible)
        {
            scriptManager.CloseScript();
        }
        else if (hit.collider != null)

        {
            if (canClickList.Contains(hit.collider.gameObject))
            {
                scriptManager.Search(hit.collider.gameObject);
            }
        } 
    }
}
