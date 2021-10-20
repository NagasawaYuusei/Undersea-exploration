using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemainsRotation : MonoBehaviour
{
    void Start()
    {
        float randomRotation = Random.Range(0, 360);
        //this.transform.rotation = Random.rotation;
        this.transform.Rotate(0, 0, randomRotation);
    }
}
