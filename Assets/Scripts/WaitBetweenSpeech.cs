using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitBetweenSpeech : MonoBehaviour
{
    public GameObject speech;
    public GameObject speech1;
    public GameObject speech2;
    public GameObject speech3;
    public GameObject speech4;
    public GameObject speech5;
    public GameObject speech6;

    public GameObject alexathink1;
    public GameObject alexathink2;

    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {

        yield return new WaitForSeconds(3);//yield on a new YieldInstruction that waits for 4 seconds.
        alexathink1.SetActive(true);

        yield return new WaitForSeconds(1);
        speech.SetActive(true);
        yield return new WaitForSeconds(4);
        speech1.SetActive(true);
        yield return new WaitForSeconds(2);
        speech2.SetActive(true);
        yield return new WaitForSeconds(2);
        speech3.SetActive(true);
        yield return new WaitForSeconds(5);

        alexathink1.SetActive(true);
       
        yield return new WaitForSeconds(1);
        speech4.SetActive(true);
        yield return new WaitForSeconds(6);
        speech5.SetActive(true);
        yield return new WaitForSeconds(6);
        speech6.SetActive(true);
     


    }
}
