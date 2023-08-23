using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.VFX;
using TMPro;



public class KnifeRespawner : MonoBehaviour
{
    public GameObject KnifeKitchen;
    public float spawnHeightOffset = 0f;

    private List<GameObject> spawnedKnifeKitchen = new List<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("You've been chopped up");
        }

        else if (other.gameObject.CompareTag("Untagged"))
        {
            Vector3 spawnPosition = transform.position + new Vector3(0f, spawnHeightOffset, 0f);
            Quaternion spawnRotation = Quaternion.Euler(0f, 90f, 0f);

            Debug.Log("knife instantiates");

            // Calculate the spawn position
            Instantiate(KnifeKitchen, spawnPosition, spawnRotation);
            StartCoroutine(DelayedDestroySelf());
        }
    }

    private IEnumerator DelayedDestroySelf()
    {
            yield return new WaitForSeconds(0.2f);
            Destroy(gameObject);
            Debug.Log("knife destroys self");
    }

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            foreach(var knife in spawnedKnifeKitchen)
            {
                Destroy(knife);
            }
            spawnedKnifeKitchen.Clear();
            Debug.Log("spawned knives destroyed");
        }
        
    }


}






// NEED HELP WITH ABOVE - NOT SPAWNING WHERE I WANT IT TO
      // Also diagonally respawning?
      // Additionally question - check how I can make the mesh of my octopus more in line with it's body



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

