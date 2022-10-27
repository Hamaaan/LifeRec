using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleCollider : MonoBehaviour
{

    void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("当たっている");
    }

}