using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragDropScript : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    //Uzglabās norādi uz objekta skriptu
    public ObjectScript objectuskripts;
    private CanvasGroup kanvasGrupa;
    private RectTransform VelkObjRectTransfer;

    void Start()
    {
        kanvasGrupa= GetComponent<CanvasGroup>();
        VelkObjRectTransfer= GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
       
    }

    public void OnDrag(PointerEventData eventData)
    {
       
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       
    }

    // Use this for initialization
   

}
