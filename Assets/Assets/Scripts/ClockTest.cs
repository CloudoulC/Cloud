//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System;

//public class ClockTest : MonoBehaviour
//{
//    public GameObject secondHand;
//    public GameObject minuteHand;
//    public GameObject hourHand;

//    private int seconds;
//    private int minutes;
//    private int hours;

//    private float secondAngle;
//    private float minuteAngle;
//    private float hourAngle;
//    private void Awake()
//    {
//        secondHand = transform.Find("Seconds").gameObject;
//        minuteHand = transform.Find("Minutes").gameObject;
//        hourHand = transform.Find("Hours").gameObject;
//    }
//    void Start()
//    {

//    }

//    void Update()
//    {
//        seconds = DateTime.Now.Second;
//        minutes = DateTime.Now.Minute;
//        hours = DateTime.Now.Hour;
//        secondAngle = (360 / 60) * seconds;
//        secondHand.transform.rotation = Quaternion.Euler(0, 0, secondAngle);
//        minuteAngle = (360 / 60) * minutes;
//        minuteHand.transform.rotation = Quaternion.Euler(0, 0, minuteAngle);
//        if (hours > 12)
//        {
//            hourAngle = (360 / 12) * (hours - 12);
//            hourHand.transform.rotation = Quaternion.Euler(0, 0, hourAngle);
//        }
//        else
//        {
//            hourAngle = (360 / 12) * hours;
//            hourHand.transform.rotation = Quaternion.Euler(0, 0, hourAngle);
//        }
//    }
//}
