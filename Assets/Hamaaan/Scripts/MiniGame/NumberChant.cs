using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NumberChant : MonoBehaviour
{

    [SerializeField] int NumberRow;

    [SerializeField] Text text;
 

    // Start is called before the first frame update
    void Start()
    {


        string NumbersRow;

        NumbersRow = ((int)Random.Range(1, 9)).ToString() + ((int)Random.Range(1, 9)).ToString() + ((int)Random.Range(1, 9)).ToString() + ((int)Random.Range(1, 9)).ToString();






    }




    // Update is called once per frame
    void Update()
    {
        
    }



}
