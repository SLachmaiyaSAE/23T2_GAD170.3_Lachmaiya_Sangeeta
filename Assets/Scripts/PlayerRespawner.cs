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
        tankReturnMessage.text = "HEAD CHEF CAUGHT YOU! RETURNED TO TANK";

        StartCoroutine(HideTankReturnMessageAfterDelay());
    }

    private IEnumerator HideTankReturnMessageAfterDelay()
    {
        yield return new WaitForSeconds(5f); // Wait for 5 seconds
        tankReturnMessage.gameObject.SetActive(false); // Hide the message
    }

    private void Respawn()
    {
        controller.enabled = false;
        Vector3 teleportPosition = new Vector3(177.6f, 10f, -16f);
        playerCharacter.transform.position = teleportPosition;
        controller.enabled = true;
    }
}
