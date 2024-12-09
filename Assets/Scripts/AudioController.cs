using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{

    [SerializeField] private AudioMixer mixer;
    private bool pauseGame = false;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseGame =! pauseGame;
        }
        
        if (pauseGame)
        {
            mixer.SetFloat("LowpassFreq", 500);
            Time.timeScale = 0f;
        }

        else if (!pauseGame)
        {
            mixer.SetFloat("LowpassFreq", 22000);
            Time.timeScale = 1f;
        }


    }
}
