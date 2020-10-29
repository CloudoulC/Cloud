using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClockTest02 : MonoBehaviour
{
    public GameObject secondHand;
    public GameObject minuteHand;
    public GameObject hourHand;

    private int sysSeconds;
    private int sysMinutes;
    private int sysHours;

    private int tempHours;

    private float secondAngle;
    private float minuteAngle;
    private float hourAngle;
    private void Awake()
    {
        secondHand = transform.Find("Seconds").gameObject;
        minuteHand = transform.Find("Minutes").gameObject;
        hourHand = transform.Find("Hours").gameObject;
    }
    void Start()
    {

    }

    void Update()
    {
        sysSeconds = DateTime.Now.Second;
        sysMinutes = DateTime.Now.Minute;
        sysHours = DateTime.Now.Hour;

        tempHours = sysHours * 3600 + sysMinutes * 60 + sysSeconds;

        secondAngle = (360 / 60) * sysSeconds;
        secondHand.transform.rotation = Quaternion.Euler(0, 0, secondAngle);
        minuteAngle = (360 / 60) * sysMinutes;
        minuteHand.transform.rotation = Quaternion.Euler(0, 0, minuteAngle);
        if (sysHours > 12)
        {
            tempHours = (sysHours - 12) * 3600 + sysMinutes * 60 + sysSeconds;
            hourAngle = 1 / 120f * tempHours;
            hourHand.transform.rotation = Quaternion.Euler(0, 0, hourAngle);
        }
        else
        {
            tempHours = sysHours * 3600 + sysMinutes * 60 + sysSeconds;
            hourAngle = 1 / 120f * tempHours;
            hourHand.transform.rotation = Quaternion.Euler(0, 0, hourAngle);
        }
    }
}
