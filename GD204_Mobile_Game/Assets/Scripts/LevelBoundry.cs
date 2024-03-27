using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = 256f;
    public static float rightSide = 270f;
    public float internalLeft;
    public float internalRight;


    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}