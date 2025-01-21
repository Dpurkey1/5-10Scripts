using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairCheck : MonoBehaviour
{
    public GameObject Stair;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3f);
        Destroy(Stair);
    }

}
