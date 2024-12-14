using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GridBrushBase;

public class Asteroid : MonoBehaviour
{

    [SerializeField] private float asteroidSpeed;
    [SerializeField] private AudioSource asteroidSound;
    [SerializeField] private AudioClip asteroidExplosion;

    public bool reached = false;

    private bool rotationActivate = true;
    private float rotationDirection;
    private float randomScale;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("XWing"))
        {
            asteroidSound.PlayOneShot(asteroidExplosion);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Shoot"))
        {
            reached = true;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("AsteroidDestroyer"))
        {
            Destroy(gameObject);
        }

    }


    private void Update()
    {
        if (rotationActivate)
        {
            rotationDirection = Random.Range(-80f, 80f);
            randomScale = Random.Range(0.5f, 1.5f);
            transform.localScale += new Vector3(randomScale, randomScale, 0);
            rotationActivate = !rotationActivate;
        }

        transform.position += new Vector3(0, -asteroidSpeed * Time.deltaTime, 0);
        transform.Rotate(0, 0, rotationDirection * Time.deltaTime);
        
    }
}

