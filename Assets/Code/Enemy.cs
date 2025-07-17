using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Enemy movement speed
    public float speed;

    //The target the enemy is moving towards
    public Transform target;

    //Damage points from an attack by the player's enemy
    public int playerDamage = 10;

    //Distance within which the enemy starts moving
    public float detectionRange = 10f;


    void Update()
    {
        // Calculate distance to target 
        float distanceToTarget = Vector3.Distance(transform.position, target.position);

        // Only move if target is within detection range
        if (distanceToTarget <= detectionRange)
        {
            //Changes the NPC position to a new one every frame
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

            //Turns the NPC each frame to face the target
            transform.LookAt(target.position);
        }
    }

    //When an enemy collides with a player, damage is inflicted on the second player
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            player.TakeDamage(playerDamage);
        }
    }
}
