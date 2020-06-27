using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private Transform player;

    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    void Update()
    {//1.836094
        transform.position = new Vector3(player.position.x, player.position.y + 2f, player.position.z - 142.9511f);
    }
}
