using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public int time2minute=1;
    public Color skyColor;
    public int time = 0;
    private int year=1, month=1, day=1;

    // Start is called before the first frame update
    void Start()
    {
        skyColor = GetComponent<SpriteRenderer>().color;
        //sky.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        skyColor = new Color32(1, 1, 1, 1);
        StartCoroutine(Tick());  
    }
    
    public void NextDay()
    {
        if(day<30)
        {
            day++;
        }
        else
        {
            if (month < 4)
            {
                day = 1;
                month++;
            }
            else
            {
                month = 1;
                year++;
            }
        }
    }
    IEnumerator Tick()
    {
        time++;
        skyColor.a = time;
        yield return new WaitForSeconds(time2minute);
        if (time>79)
        {
            time = 0;
            NextDay();
        }
        StartCoroutine(Tick());
    }
}
