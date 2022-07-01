using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStop : MonoBehaviour
{
    public MoveForward playerMovement;
    void OnCollisionEnter(Collision collision)
    {
        playerMovement.enabled = false;
    }
}
