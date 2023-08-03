using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JellyArea : MonoBehaviour
{
    [SerializeField] private TextMeshPro textBox;

    private void Start()
    {
        textBox.enabled = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("YOU ARE IN THE JELLY");
        //GetComponent<Renderer>().material.color = Color.red;

        // other.transform.position = new Vector3(0, 1, 0);

        // restart the scene!
        // UnityEngine.SceneManagement.ScenenManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        textBox.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("YOU HAVE LEFT THE JELLY");
        GetComponent<Renderer>().material.color = Color.red;
    }

    //private void OnTriggerStay(Collider other)
    //{
    //    GetComponent<Renderer>().material.color = Random.ColorHSV();
    //    transform.localScale = Vector3.one * 3 * Random.Range(1.1f, 2f);

        //// Restart the scene
        //UnityEngine. SceneManagement.LoadScene(SceneManager)

}
  
