using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateAlarm : MonoBehaviour
{
    
    public GameObject alarmOn;
    public GameObject alarmOff;

    public GameObject recuperation;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "alarm")
        {
            alarmOn.SetActive(false);
            alarmOff.SetActive(true);
            recuperation.SetActive(true);

        }
    }
}
