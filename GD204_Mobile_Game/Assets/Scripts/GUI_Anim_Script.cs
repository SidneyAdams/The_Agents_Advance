using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_AnimScript : MonoBehaviour
{
        public bool isTimed = false;
        public float screenTime = 4f;
        public GameObject targetTimedScreen;
        private float startTime = 0f;

        void Start()
        {
            startTime = Time.time;
        }

        void OnEnable()
        {
            startTime = Time.time;
        }

    void Update()
    {
        if (isTimed)
        {
            while (Time.time < startTime + screenTime)
            {
                return;
            }
            if (targetTimedScreen)
            {
                gameObject.SetActive(false);
                targetTimedScreen.SetActive(true);
            }
        }
    }
}
