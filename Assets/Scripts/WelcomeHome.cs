using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WelcomeHome : MonoBehaviour
{

    [SerializeField] private TextMeshPro textBox;

    private void Start()
    {
        textBox.enabled = false;
    }


    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        textBox.enabled = true;
    }


    private void OnTriggerExit(Collider other)
    {
        Debug.Log("YOU HAVE LEFT THE JELLY");
        GetComponent<Renderer>().material.color = Color.green;

        //// Restart the scene
        //UnityEngine. SceneManagement.LoadScene(SceneManager)
    }
}