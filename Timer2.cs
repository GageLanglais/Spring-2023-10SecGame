using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer2 : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 2f;
    public Text Clock;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
  
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        Clock.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            Application.LoadLevel("SampleScene");

        }
    }
}
