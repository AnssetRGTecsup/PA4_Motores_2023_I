using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [HideInInspector]
    public Vector3 startPosition;
    private float minCameraX = 0f, maxCameraX = 14f;

    [HideInInspector]
    public bool isFollowing;
    [HideInInspector]
    public Transform playerToFollow;
    
    void Awake()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFollowing)
        {
            transform.position = new Vector3(playerToFollow.position.x, playerToFollow.position.y, transform.position.z);
        }
    }

    public void SetPlayer(Transform player)
    {
        playerToFollow = player;
        isFollowing = true;
    }
}
