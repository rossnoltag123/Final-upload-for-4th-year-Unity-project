
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slots : MonoBehaviour , IDropHandler
{
    /// <summary>
    /// Game object item- return child object (0 in the command input area)
    /// </summary>
    public GameObject item
    {
        get
        {
            if (transform.childCount > 0 )
            {
                return transform.GetChild (0).gameObject;
            }
            return null;
        }

    }

    /// <summary>
    /// If item dropped outside child object 0 , return to original position
    /// </summary>
    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            Dragable.itemBeingDragged.transform.SetParent(transform);
        }
    }
}
