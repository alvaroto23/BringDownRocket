using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Audio;

public class gameController : MonoBehaviour
{

    [SerializeField] private ShootSpawner shooter;
    [SerializeField] private AudioMixer mixer;
    private bool pauseGame = false;

    private void OnPauseAndPlay ()
    {
        pauseGame =! pauseGame;
        
        if (pauseGame)
        {
            shooter.shootPosible();
            mixer.SetFloat("LowpassFreq", 500);
            Time.timeScale = 0f;
        }

        else if (!pauseGame)
        {
            shooter.shootPosible();
            mixer.SetFloat("LowpassFreq", 22000);
            Time.timeScale = 1f;
        }


    }
}
