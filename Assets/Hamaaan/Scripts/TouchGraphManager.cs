using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchGraphManager : MonoBehaviour, IDragHandler, IDropHandler, IPointerEnterHandler
{
    public Color color;

    Image rend;

    [SerializeField] Image PickedColor;

    private void Start()
    {
        rend = GetComponent<Image>();
        PickedColor = PickedColor.GetComponent<Image>();
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        color = PickedColor.color;

        if (Input.GetMouseButton(0))
        {
            rend.color = color;
        }


    }

    public void OnDrag(PointerEventData eventData)
    {
        //rend.color = col;

        //Debug.Log("drag");
    }

    public void OnDrop(PointerEventData eventData)
    {
        //Destroy(gameObject);
        //Debug.Log("drop");

    }

}
