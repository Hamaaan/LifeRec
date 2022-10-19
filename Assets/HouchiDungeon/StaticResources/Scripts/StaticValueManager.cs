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

    public float PlayerExp = 1;

    public float PlayerHP = 5;

    public float PlayerPower = 5;

    public float PlayerDefence = 5;

    public float PlayerRange = 5;

    public float PlayerSpeed = 5;

    public int NumberOfKills = 0;




    public void subroutine()
    {
        Debug.Log("サブルーチンコール");
    }
}
