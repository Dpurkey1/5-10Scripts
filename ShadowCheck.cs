using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowCheck : MonoBehaviour
{
    public GameObject Wall;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3);
        Destroy(Wall);
    }

}
