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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
        //if (hit.collider != null)
        //{
        //    //Vector2 targetPosition = GameObject.Find($"{hit.collider.name}").transform.position;
        //    targetPosition = hit.transform.position;

        //    InstantiateSelectRing();
        //}
        //else
        //{
        //    onSelected = false;
        //    Destroy(GameObject.FindGameObjectWithTag("SelectedRing"));
        //    nameBox.SetActive(false);
        //
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

    //void InstantiateSelectRing()
    //{
    //    if (!onSelected && !GameObject.FindGameObjectWithTag("SelectedRing"))
    //    {
    //        onSelected = true;
    //        nameBox.SetActive(true);
    //        Instantiate(seletedRingPrefabs, targetPosition, transform.rotation);
    //    }
    //    else if (onSelected && GameObject.FindGameObjectWithTag("SelectedRing"))
    //    {
    //        GameObject.FindGameObjectWithTag("SelectedRing").transform.position = targetPosition;
    //    }
    //}
}
