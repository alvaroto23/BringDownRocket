using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class AsteroidsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject asteroid;
    [SerializeField] private float spawningSpeed;
    [SerializeField] private AudioSource asteroidSound;
    [SerializeField] private AudioClip asteroidExplosion;
    private List<Asteroid> asteroids = new List<Asteroid>();
    private float sumon = 0;
    private float spawnTime;

    private void Start()
    {
        spawnTime = Random.Range(1f,7f);
    }

    private void spawnAsteroid()
    {
        Vector3 sapwn = new Vector3(Random.Range(-8, 8), 12, 0);
        GameObject instanAsteroid = Instantiate(asteroid, sapwn, Quaternion.identity);
        Asteroid asteroidComponent = instanAsteroid.GetComponentInChildren<Asteroid>();
        asteroids.Add(asteroidComponent);
    }

    private void Update()
    {

        sumon += spawningSpeed * Time.deltaTime;
        if (sumon >= spawnTime)
        {
            spawnAsteroid();
            spawnTime = Random.Range(1f, 7f);
            sumon = 0;
        }

        for (int i = 0; i < asteroids.Count; i++)
        {
            if (asteroids[i].reached == true)
            {
                asteroidSound.PlayOneShot(asteroidExplosion);
                asteroids.Remove(asteroids[i]);
                break;
            }
        }


    }
}