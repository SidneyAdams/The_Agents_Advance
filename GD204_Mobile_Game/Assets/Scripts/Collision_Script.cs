using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision_Script : MonoBehaviour
{
    bool gameOver;
    public AudioClip boost;
    public AudioClip spike;
    public AudioClip mine;
    public AudioClip civCar;

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
            if (other.gameObject.name =="Nitrous_Canister_Prefab" || other.gameObject.name == "Nitrous_Canister_Prefab(Clone)")
            {
                AudioSource.PlayClipAtPoint(boost, gameObject.transform.position);
            }
        }
        if (other.gameObject.tag == "Obstacle")
        {
            if (other.gameObject.name == "Spike_Prefab" || other.gameObject.name == "Spike_Prefab(Clone)")
            {
                AudioSource.PlayClipAtPoint(spike, gameObject.transform.position);
            } 
            if (other.gameObject.name == "Mine_Prefab" || other.gameObject.name == "Mine_Prefab(Clone)")
            {
                AudioSource.PlayClipAtPoint(mine, gameObject.transform.position);
            } 
            if (other.gameObject.name == "Civilian_Car_Prefab" || other.gameObject.name == "Civilian_Car_Prefab(Clone)")
            {
                AudioSource.PlayClipAtPoint(civCar, gameObject.transform.position);
            }
            gameOver = true;            
        }

        if (gameOver == true)
        {
            SceneManager.LoadScene("Mission_Scrubbed_UI");
            Debug.Log("gameOver");
        }
    }
}
