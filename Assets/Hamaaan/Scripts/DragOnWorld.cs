using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DragOnWorld : MonoBehaviour, IDragHandler, IDropHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnDrag(PointerEventData eventData)
    {
        Rigidbody2D rd = GetComponent<Rigidbody2D>();

        if (GetComponent<Rigidbody2D>())
        {
            rd.isKinematic = true;
        }

        Vector3 TargetPos = Camera.main.ScreenToWorldPoint(eventData.position);
        TargetPos.z = 0;
        transform.position = TargetPos;

        if (GetComponent<Rigidbody2D>())
        {
            rd.isKinematic = false;
        }

        //Debug.Log("drag");


    }

    public void OnDrop(PointerEventData eventData)
    {
        //Destroy(gameObject);
        //Debug.Log("drop");

    }
}
