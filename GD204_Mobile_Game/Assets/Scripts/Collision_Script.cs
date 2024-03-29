using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Script : MonoBehaviour
{
    bool gameOver;
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
        if (other.gameObject.CompareTag("Collectable"))
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
        }

        if (gameOver == true)
        {
            Debug.Log("gameOver");
        }
    }
}
