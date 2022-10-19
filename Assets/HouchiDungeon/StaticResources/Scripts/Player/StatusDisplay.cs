using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //StaticValueManager.instance.subroutine();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "PlayerHP : " + StaticValueManager.instance.PlayerHP.ToString();


    }
}
