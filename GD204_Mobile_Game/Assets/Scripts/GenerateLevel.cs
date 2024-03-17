using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    //public GameObject[] Level_Section;
    public GameObject Level_Section;
    public GameObject Player;
    public int zPos = 105;
    public bool creatingSection = false;
    private float xCoord = 12.2471f;
    private Transform LevelTransform;
    private Transform PlayerTransform;
    //public int secNum;

    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
        LevelTransform = GameObject.Find("Level_Section").transform;
        PlayerTransform = GameObject.Find("Protag_Car_Prefab").transform;

       // if(LevelTransform.position.z <= PlayerTransform.position.z - 50)
        //{
        //    Destroy(Level_Section);
       // }
    }

    IEnumerator GenerateSection()
    {
        //secNum = Random.Range(0, 3);
        //Instantiate(Level_Section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        Instantiate(Level_Section, new Vector3(xCoord, 0, zPos), Quaternion.identity);
        zPos += 99;
        yield return new WaitForSeconds(3);
        creatingSection = false;
    }
}
