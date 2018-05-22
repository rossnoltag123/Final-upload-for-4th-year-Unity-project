using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dragable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    /// <summary>
    /// Instantiating item being dragged
    /// </summary>
    public static GameObject itemBeingDragged;

    /// <summary>
    /// initializing positiion
    /// </summary>
    Vector3 startPosition;

    /// <summary>
    /// initializing positiion
    /// </summary>
    Transform startParent;

    /// <summary>
    /// This method is a member of the IBeginDragHandler interface, it manages the object to be dragged
    /// </summary>
    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;  //Double check ray casts 
    }

    /// <summary>
    /// This method manages the movement of the mouse pointer to the object being draged
    /// </summary>
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    /// <summary>
    /// This method manages when the draging of the object is too stop
    /// </summary>
    public void OnEndDrag(PointerEventData eventData)
    {
        itemBeingDragged = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent != startParent)
        {
            transform.position = startPosition;
        }
    }
}
