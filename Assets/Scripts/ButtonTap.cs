using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonTap : MonoBehaviour
{
    [SerializeField] public GameObject buttonTap;
    [SerializeField] public GameObject sinkRiseWater;

    private bool waterRising = false;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Tap has been opened");

        // if the player character triggers this method.....
        if (other.CompareTag("Player"))
        {
        // increase height of sinkwater 
         if (!waterRising)
            {
                Vector3 newPosition = sinkRiseWater.transform.position;
                newPosition.y += 30f; 
                sinkRiseWater.transform.position = newPosition;

                waterRising = true; 
            }
        }
    }
}
