using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Generation_Script : MonoBehaviour
{
    public GameObject[] Level_Sections;
    public float zSpawn = 0;
    public float SectionLength = 100;
    public int numberOfSections = 5;
    private List<GameObject> activeSections = new List<GameObject>();
    public Transform playerTransform;

    void Start()
    {
        for (int i = 0; i < numberOfSections; i++)
        {
            if (i == 0)
                SpawnTile(0);
            else
                SpawnTile(Random.Range(0, Level_Sections.Length));
        }
    }

    void Update()
    {
        if (playerTransform.position.z - 100 > zSpawn - (numberOfSections * SectionLength))
        {
            SpawnTile(Random.Range(0, Level_Sections.Length));
            DeleteTile();
        }
    }

    public void SpawnTile(int tileIndex)
    {
        GameObject go = Instantiate(Level_Sections[tileIndex], transform.forward * zSpawn, transform.rotation);
        activeSections.Add(go);
        zSpawn += SectionLength;
    }

    private void DeleteTile()
    {
        Destroy(activeSections[0]);
        activeSections.RemoveAt(0);
    }
}
