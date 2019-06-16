using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;        //Public variable to store a reference to the player game object



     void Update()
    {
        transform.position = new Vector3
        (
            Mathf.Clamp(player.position.x, 0f, 0f),
            Mathf.Clamp(player.position.y,-1f,1000000f),
            transform.position.z
        );
    }
}

