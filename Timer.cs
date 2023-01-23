using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 10f;
    public Text Clock;
    public Text win;
    public AudioSource musicSource;
    public AudioClip victory;
    public static bool gameIsPaused;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        win.text = ("");  
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        Clock.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            musicSource.clip = victory;
            musicSource.Play();
            currentTime = 0;
            win.text = ("You Win!");
            PauseGame ();

        }
    }
    
    void PauseGame ()
    {
        Time.timeScale = 0f;
    }
}