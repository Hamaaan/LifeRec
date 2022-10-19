using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticValueManager : MonoBehaviour
{
    //シングルトンの宣言
    public static StaticValueManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //PlayerData

    public float PlayerLevel = 1;

    public float PlayerHP = 5;



    public void subroutine()
    {
        Debug.Log("サブルーチンコール");
    }
}
