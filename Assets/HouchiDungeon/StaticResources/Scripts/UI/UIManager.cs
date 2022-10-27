using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    StaticValueManager _svm;

    public Text LevelText;
    public Text ExpText;
    //public Text PlayerText;


    // Start is called before the first frame update
    void Start()
    {
        _svm = StaticValueManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        LevelText.text = _svm.PlayerLevel.ToString();
        ExpText.text = _svm.PlayerExp.ToString();
    }
}
