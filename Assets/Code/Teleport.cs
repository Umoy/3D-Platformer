using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;

    void OnTriggerEnter(Collider other)
    {
        //Changes the player's position to the position of another teleport
        other.transform.position = teleportPoint.position;
    }

}
