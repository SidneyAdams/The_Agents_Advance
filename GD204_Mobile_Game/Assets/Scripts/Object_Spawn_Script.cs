using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawn_Script : MonoBehaviour
{
    public GameObject player;
    public GameObject [] prefabs;
    private Vector3 spawnObstaclesPosition;
    private float xCoord;
    

   
    // Update is called once per frame
    void Update()
    {
        float distanceToHorizon = Vector3.Distance(player.gameObject.transform.position, spawnObstaclesPosition);

        if (distanceToHorizon < 120f)
        {
            spawnObstacle();
        }
        xCoord = Random.Range(-19f, -5f);
    }

    void spawnObstacle()
    {
        spawnObstaclesPosition = new Vector3(xCoord, 0, spawnObstaclesPosition.z + 30);
        Instantiate(prefabs[(Random.Range(0, prefabs.Length))], spawnObstaclesPosition, Quaternion.identity);
    }

}


