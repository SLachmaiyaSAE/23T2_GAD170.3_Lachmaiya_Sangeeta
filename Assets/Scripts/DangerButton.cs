using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


// Aaron's code below 

public class DangerButton : MonoBehaviour
{
    [SerializeField] private TextMeshPro tutorialText;
    [SerializeField] private bool isPlayerCharacterNextToButton = false;
    [SerializeField] private GameObject fallingJellyPrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private TextMeshPro buttonWarningText;


    private void Update()
    {
        // When the player presses E to activate the button.....
        if (Input.GetKeyDown(KeyCode.E) && isPlayerCharacterNextToButton)
        {
            //.....spawn a falling jelly cube above them! 
            Debug.Log("Danger zone activated");

           Instantiate(fallingJellyPrefab, spawnPoint.position, Random.rotation);
            // GameObject newJelly = Instantiate(fallingJellyPrefab, spawnPoint.position, Random.rotation);
            // newJelly.GetComponent<Rigidbody>().AddForce(Vector3.up * 800f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger has been triggered!");

        // if the player character triggers this method.....
        if (other.CompareTag("Player"))
        {
            // ....show things!
            buttonWarningText.enabled = true;
            isPlayerCharacterNextToButton = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger has been left all alone");

        //if player character triggers this method...
        if (other.CompareTag("Player"))
        {
            // ....hide things!
            buttonWarningText.enabled = false;
            isPlayerCharacterNextToButton = false;

        }
    }
}
