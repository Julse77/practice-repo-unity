using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    GameObject player;
    Vector3 offset;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        offset = player.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position - offset;
    }
}
