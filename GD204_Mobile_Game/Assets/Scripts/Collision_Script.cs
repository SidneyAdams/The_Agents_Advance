using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision_Script : MonoBehaviour
{
    bool gameOver;
    AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectable")
        {
            Destroy(other.gameObject);
            Debug.Log("PickUp");
        }
        if (other.gameObject.tag == "Obstacle")
        {
            gameOver = true;
        }

        if (gameOver == true)
        {
            SceneManager.LoadScene("Mission_Scrubbed_UI");
            Debug.Log("gameOver");
        }
    }
}
