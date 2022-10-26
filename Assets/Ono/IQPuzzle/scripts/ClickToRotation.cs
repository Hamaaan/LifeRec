using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickToRotation : MonoBehaviour
{
     [SerializeField]
    [Tooltip("NextRotation")]
    private GameObject NextRotation;

    public void onClickAct()
     {  
        Vector3 tmp = this.gameObject.transform.position;
        Instantiate(NextRotation, new Vector3(tmp.x, tmp.y, tmp.z), Quaternion.identity);
        Destroy( this.gameObject );
        //Debug.Log("タッチされたにゃー");

    }
}

