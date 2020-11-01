using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterBox : MonoBehaviour
{
    GameObject[] inside;
    GameObject[] outside;
    GameObject[] cars;
    private void Start()
    {
        inside = GameObject.FindGameObjectsWithTag("inside");
        outside = GameObject.FindGameObjectsWithTag("outside");
        cars = GameObject.FindGameObjectsWithTag("traffic");
        foreach(GameObject obj in inside)
        {
            obj.GetComponent<AudioLowPassFilter>().cutoffFrequency = 1000;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //lpf = other.gameObject.GetComponent<AudioLowPassFilter>();
        foreach(GameObject gameObject in inside)
        {
            gameObject.GetComponent<AudioLowPassFilter>().cutoffFrequency = 5000;
        }
        foreach (GameObject gameObject in cars)
        {
            gameObject.GetComponent<AudioLowPassFilter>().cutoffFrequency = 1000;
        }
        foreach (GameObject obj in outside)
        {
            obj.GetComponent<AudioLowPassFilter>().cutoffFrequency = 1000;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        foreach (GameObject gameObject in outside)
        {
            gameObject.GetComponent<AudioLowPassFilter>().cutoffFrequency = 5000;
        }
        foreach (GameObject gameObject in cars)
        {
            gameObject.GetComponent<AudioLowPassFilter>().cutoffFrequency = 5000;
        }
        foreach (GameObject obj in inside)
        {
            obj.GetComponent<AudioLowPassFilter>().cutoffFrequency = 1000;
        }
    }
}
