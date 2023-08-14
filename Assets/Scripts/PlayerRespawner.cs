using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawner : MonoBehaviour
{

    public float threshold = 0;
    public float PlayerRespawn = 0f;
    public GameObject octopus;

    void DestroySelf()
    {
        if(transform.position.y < threshold)
        {
            DestroySelf();
            Vector3 spawnPosition = transform.position + new Vector3(0f, PlayerRespawn, 0f);
            Instantiate(octopus, spawnPosition, Quaternion.identity);
        }
            
    }
}




// NEED HELP TO DO THIS _ LOW PRIORITY ITEM
// looking to respawn player to start poition if they are killed or fall off the table