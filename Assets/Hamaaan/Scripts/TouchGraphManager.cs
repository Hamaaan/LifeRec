using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchGraphManager : MonoBehaviour, IDragHandler, IDropHandler, IPointerEnterHandler
{
    [SerializeField] Color[] colors;

    Image rend;

    private void Start()
    {
        rend = GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (Input.GetMouseButton(0))
        {
            rend.color = colors[0];
        }


    }

    public void OnDrag(PointerEventData eventData)
    {
        rend.color = colors[0];

        //Debug.Log("drag");
    }

    public void OnDrop(PointerEventData eventData)
    {
        //Destroy(gameObject);
        //Debug.Log("drop");

    }

}
