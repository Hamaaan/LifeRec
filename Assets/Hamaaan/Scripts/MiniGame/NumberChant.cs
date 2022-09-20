using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NumberChant : MonoBehaviour
{
    private string NumbersRow;

    [SerializeField] Text text;

    public ClickButton ClickButton;

    private string InputNumbers;


    // Start is called before the first frame update
    void Start()
    {


        NumbersRow = ((int)Random.Range(1, 9)).ToString() + ((int)Random.Range(1, 9)).ToString() + ((int)Random.Range(1, 9)).ToString() + ((int)Random.Range(1, 9)).ToString();

        text = text.GetComponent<Text>();
        text.text = NumbersRow;

    }




    // Update is called once per frame
    void Update()
    {
        if(ClickButton.count == 4)
        {
            InputNumbers = string.Join("", ClickButton.InputNumbers);
            if(NumbersRow == InputNumbers)
            {
                Debug.Log("right");
            }
            else
            {
                Debug.Log("false");
            }
        }
    }



}
