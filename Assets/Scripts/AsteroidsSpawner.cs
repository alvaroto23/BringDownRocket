using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class AsteroidsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject asteroid;
    [SerializeField] private float spawningSpeed = 5;
    [SerializeField] private AudioSource asteroidSound;
    [SerializeField] private AudioClip asteroidExplosion;
    private float sumon = 0;
    private float spawnTime;

    private void Start()
    {
        spawnTime = Random.Range(1f,7f);
    }

    private void Update()
    {

        sumon += spawningSpeed * Time.deltaTime;
        if (sumon >= spawnTime)
        {
            Vector3 sapwn = new Vector3(Random.Range(-8, 8), 12, 0);
            Instantiate(asteroid, sapwn, Quaternion.identity);
            spawnTime = Random.Range(1f, 7f);
            sumon = 0;
        }

    }
}