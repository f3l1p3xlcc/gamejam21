using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Drag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    Vector3 originalPos;
    public GameObject target = default;
    bool IsCollidingWithTarget = false;
    public GameObject FUSE;


    #region DragFunctions

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        originalPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        if (IsCollidingWithTarget)
        {
            transform.position = target.transform.position;
            print(GameObject.FindWithTag("FUSE"));
            Destroy(GameObject.FindWithTag("FUSE"));
            SceneManager.LoadScene("SampleScene");
        }
        else
        {
            transform.position = originalPos;
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (target == collider.gameObject)
        {
            IsCollidingWithTarget = true;
        }
        print(IsCollidingWithTarget);
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (target == collider.gameObject)
        {
            IsCollidingWithTarget = false;
        }
    }


    #endregion

    private void Update()
    {

    }
}