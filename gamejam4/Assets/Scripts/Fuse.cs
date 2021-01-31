using UnityEngine;
using System.Collections;

public class Fuse : MonoBehaviour
{
    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        transform.Translate(Vector2.down * Time.deltaTime * 10);
    }
}