using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour
{// Transform refers to player info 
    public Transform player;

    public Vector3 offset;

    void Update()
    {
        transform.position = player.position + offset;   
    }
}
