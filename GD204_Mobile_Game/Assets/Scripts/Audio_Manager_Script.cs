using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Manager_Script : MonoBehaviour
{
    public GameObject spike;
    public AudioClip spikeSound;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(spike.activeInHierarchy == false)
        {
            AudioSource.PlayClipAtPoint(spikeSound, spike.transform.position);
        }
        
    }
}
