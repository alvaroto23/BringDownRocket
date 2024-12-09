using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootSpawner : MonoBehaviour
{
    [SerializeField] private GameObject shoot;
    [SerializeField] private Transform parentPos;
    private bool canShoot = true;

    private AudioSource audioController;
    [SerializeField] private AudioClip shootClip;


    private void Start()
    {
        audioController = GetComponent<AudioSource>();
    }

    public void shootPosible()
    {
        canShoot = !canShoot;
    }

    private void OnShoot ()
    {
        if (canShoot)
        {
        Vector3 cannon = new Vector3(parentPos.position.x, parentPos.position.y, 0);
        audioController.PlayOneShot(shootClip);

        // (Prefab a instnacias, posición inicial, rotación inicial)
        // Quaternion.identity viene a ser rotación 0
        Instantiate(shoot, cannon, Quaternion.identity);
        }
    }
}
