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
    public int playerDamage = 2;


    void Update()
    {
        //Changes the NPC position to a new one every frame
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        //Turns the NPC each frame to face the target
        transform.LookAt(target.position);
    }

    //When an enemy collides with a player, damage is inflicted on the second player
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.TakeDamage(playerDamage);
    }
}
