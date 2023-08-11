using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.VFX;



public class ImpactTester : MonoBehaviour
{
    public GameObject KnifeKitchenPrefab;
    public Vector3 spawnPosition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("You've been chopped up");
        }
        else if (other.gameObject.CompareTag("Untagged"))
        {
            DestroySelf();
            Instantiate(KnifeKitchenPrefab, spawnPosition, Quaternion.identity);
        }
    }

    private void DestroySelf()
    {
        // Implement your destroy logic here
        Destroy(gameObject);
    }
}

// ORIGINAL CODE GIVEN TO US IN CLASS FROM AARON

//public class ImpactTester : MonoBehaviour
//{
//    // we want this script to handle COLLISION and TRIGGER detection
//    // when our object impacts another, we want to PRINT TEXT
//    // if you put UnityEngine. 
//    // collision enter 
//    private void OnCollisionEnter(Collision collision)
//    {
//        Debug.Log("Ouch");
//        // play a sound effect
//        // destroy one or two other objects
//        // change colour of object
//        // Show a particle effect
//        // Destroy a game object that this script is attached to
//        Destroy(gameObject);
//        // 
//        Destroy(collision.gameObject);
//    }
//    private void OnTriggerEnter(Collider other)
//    {
//        Debug.Log("Ouch, i have triggered something");
//    }

