using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecuperationActivation : MonoBehaviour
{
    public GameObject recuperation;
    private void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);
        recuperation.SetActive(true);
    }
}
