using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_P1 : MonoBehaviour
{
    [SerializeField]
    private Transform[] placas;

    public static bool win;
    // Start is called before the first frame update
    void Start()
    {
        win = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (placas[0].rotation.z == 0 &&
            placas[1].rotation.z == 0 &&
            placas[2].rotation.z == 0 &&
            placas[4].rotation.z == 0 &&
            placas[5].rotation.z == 0 &&
            placas[6].rotation.z == 0 &&
            placas[7].rotation.z == 0 &&
            placas[8].rotation.z == 0 &&
            placas[9].rotation.z == 0 &&
            placas[11].rotation.z == 0 &&
            placas[12].rotation.z == 0 &&
            placas[13].rotation.z == 0)
        {
            win = true;
            Debug.Log("Win");
            Debug.Log("WIN WIN WIN");
        }
    }
}
