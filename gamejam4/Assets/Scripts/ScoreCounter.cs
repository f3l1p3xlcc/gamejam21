using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    static int scoreCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreCounter = scoreCounter + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //ScoreText.text = scoreCounter.ToString();
    }
}
