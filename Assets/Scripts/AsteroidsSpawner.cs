using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class AsteroidsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject asteroid;
    [SerializeField] private float spawningSpeed = 5;
    private float velocity = 0;
    private float spawnTime;

    private void Start()
    {
        spawnTime = Random.Range(1f,7f);
        
    }

    private void Update()
    {

        velocity += spawningSpeed * Time.deltaTime;
        if (velocity >= spawnTime)
        {
            Vector3 sapwn = new Vector3(Random.Range(-8, 8), 12, 0);
            Instantiate(asteroid, sapwn, Quaternion.identity);
            spawnTime = Random.Range(1f, 7f);
            velocity = 0;
        }

    }
}