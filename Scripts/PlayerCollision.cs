using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter (UnityEngine.Collision collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "Obstacle") {

            movement.enabled = false;
        }

    }

}
