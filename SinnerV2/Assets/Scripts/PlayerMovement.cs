using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W pressed");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S pressed");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A pressed");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D pressed");
        }
    }
}
