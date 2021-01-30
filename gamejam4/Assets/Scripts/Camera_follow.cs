using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_follow : MonoBehaviour
{
    public Transform playerImage;

    void FixedUpdate ()
    {
        transform.position = new Vector3(playerImage.position.x, playerImage.position.y, transform.position.z);
    }
}
