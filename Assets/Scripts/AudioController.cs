using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{

    private AudioSource audioController;
    [SerializeField] private AudioClip clip;
    [SerializeField] private AudioMixer mixer;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            audioController.Play();
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            audioController.PlayOneShot(clip);
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            audioController.Stop();
        }
        
        if (Input.GetKeyDown(KeyCode.H))
        {
            audioController.Pause();
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            mixer.SetFloat("LowpassFreq", 500);
        }


    }
}
