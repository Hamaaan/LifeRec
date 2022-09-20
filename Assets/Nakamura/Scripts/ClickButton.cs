using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickButton : MonoBehaviour
{
    [SerializeField] private Text Numtext;
    public string[] InputNumbers = new string[4];
    public int count;

    private void Start()
    {
        count = 0;
       
    }

    public void OnClick(int num)
    {
        if (count < 4)
        {
            InputNumbers[count] = "" + num;
            Numtext.text = string.Join("", InputNumbers);
            count++;
        }
    }
    
}
