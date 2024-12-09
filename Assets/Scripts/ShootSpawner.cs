using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootSpawner : MonoBehaviour
{
    [SerializeField] private GameObject shoot;
    [SerializeField] private Transform parentPos;

    private AudioSource audioController;
    [SerializeField] private AudioClip shootClip;


    private void Start()
    {
        audioController = GetComponent<AudioSource>();
    }
    private void OnShoot ()
    {
        Vector3 cannon = new Vector3(parentPos.position.x, parentPos.position.y, 0);
        audioController.PlayOneShot(shootClip);

        // (Prefab a instnacias, posición inicial, rotación inicial)
        // Quaternion.identity viene a ser rotación 0
        Instantiate(shoot, cannon, Quaternion.identity);
    }
}
