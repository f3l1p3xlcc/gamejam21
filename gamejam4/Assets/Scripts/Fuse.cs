using UnityEngine;
using System.Collections;

public class Fuse : MonoBehaviour
{
    int TimeOut = 0; 
    
    public void Start()
    {
        StartCoroutine(TimerFuse());
    }

    IEnumerator TimerFuse()
    {
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        yield return new WaitForSeconds(3);

        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        TimeOut = 25;

        yield return new WaitForSeconds(12);

        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        TimeOut = 0;
    }

    private void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * TimeOut);
    }
}