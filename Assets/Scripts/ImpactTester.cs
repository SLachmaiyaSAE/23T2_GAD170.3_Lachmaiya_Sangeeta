using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ImpactTester : MonoBehaviour
{
    // we want this script to handle COLLISION and TRIGGER detection

    // when our object impacts another, we want to PRINT TEXT

    // if you put UnityEngine. 


    // collision enter 

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ouch");

        // play a sound effect
        // destroy one or two other objects
        // change colour of object
        // Show a particle effect

        // Destroy the a game object that this cript is attached to
        Destroy(gameObject);

        // 
        Destroy(collision.gameObject);

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ouch, i have triggered something");
    }



}
