using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovnemt : MonoBehaviour
{
    public float moveSpeed = 20;
    public float leftRightSpeed = 12.5f;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || (SwipeControls.swipeRight))
        {
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || (SwipeControls.swipeRight))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);   
            }
        }
    }
}
