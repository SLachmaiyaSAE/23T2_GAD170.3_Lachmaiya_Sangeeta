using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBoard : MonoBehaviour
{
    [SerializeField] public GameObject buttonPushBoard;
    [SerializeField] private GameObject board4;

    private bool boardPushed = false;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
            // push board by making it rotate sightly and watch them domino
            if(boardPushed == false)
            {
            Debug.Log("The board has been pushed");
            //Vector3 newPosition = board4.transform.position;
            //newPosition.x += 30f;
            //board4.transform.position = newPosition;
            //boardPushed = true;

                board4.GetComponent<Rigidbody>().AddTorque(0f, 0f, 1000f);

            }
    }
}

