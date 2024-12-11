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



    private void Update()
    {
        velocity += spawningSpeed * Time.deltaTime;
        if (velocity >= 5)
        {
            Vector3 sapwn = new Vector3(Random.Range(-8, 8), 12, 0);
            Instantiate(asteroid, sapwn, Quaternion.identity);
            velocity = 0;
        }

    }
}