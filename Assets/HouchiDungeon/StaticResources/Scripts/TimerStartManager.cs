using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TimerStartManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneChangeTo(int num)
    {
        SceneManager.LoadScene(num);
    }

    public void SceneChangeTo(string name)
    {
        SceneManager.LoadScene(name);
    }
}
