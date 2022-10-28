using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleCollider : MonoBehaviour
{
    public bool Correct;
    [SerializeField]
    private GameObject CorrectPiece;
    void Start()
    {
        Correct = false;
        GetTag();
    }

    public void GetTag()
    {
        Debug.Log(CorrectPiece.tag);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("すり抜けている");
        
        if(other.CompareTag("WhitePiece")){
            //Debug.Log("白ピースきちゃ！");
        
        Correct = true;

        if(Correct == true)
        {
        Debug.Log(this.gameObject.name);
        }

    }
    }

}