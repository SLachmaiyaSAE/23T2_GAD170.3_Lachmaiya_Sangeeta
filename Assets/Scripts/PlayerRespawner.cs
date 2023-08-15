using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerRespawner : MonoBehaviour
{
    [SerializeField] GameObject playerCharacter;
    [SerializeField] CharacterController controller;
    [SerializeField] TextMeshProUGUI tankReturnMessage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            ShowTankReturnMessage();
            Respawn();
        }
    }

    private void ShowTankReturnMessage()
    {
        tankReturnMessage.gameObject.SetActive(true);
        tankReturnMessage.text = "The head chef caught you! Returned to tank";
    }

    private void Respawn()
    {
        controller.enabled = false;
        Vector3 teleportPosition = new Vector3(-56.6f, 9.2f, -20.7f);
        playerCharacter.transform.position = teleportPosition;
        controller.enabled = true;
    }
}







//    public float threshold = 0;
//    public float PlayerRespawn = 0f;
//    public GameObject octopus;

//    void DestroySelf()
//    {
//        if(transform.position.y < threshold)
//        {
//            DestroySelf();
//            Vector3 spawnPosition = transform.position + new Vector3(0f, PlayerRespawn, 0f);
//            Instantiate(octopus, spawnPosition, Quaternion.identity);
//        }

//    }
//}



// NEED HELP TO DO THIS _ LOW PRIORITY ITEM
// looking to respawn player to start poition if they are killed or fall off the table