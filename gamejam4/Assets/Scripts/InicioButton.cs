using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class InicioButton : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public GameObject target = default;
    //public UnityEngine.Video.VideoClip videoClip;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
    }


    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        print(GameObject.FindWithTag("VideoT"));
        Destroy(GameObject.FindWithTag("VideoT"));
        //target.videoClip.Play();
        SceneManager.LoadScene("HistoriaMovie");
    }
   
    void Update()
    {
        
    }
}
