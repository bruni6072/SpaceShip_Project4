using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAlarm : MonoBehaviour
{
    public GameObject alarmOn;
    public GameObject alarmOff;
    public GameObject Speech;

    

   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "alarm")
        {
            alarmOn.SetActive(true);
            alarmOff.SetActive(false);
            Speech.SetActive(true);
        }
    }

   
}
