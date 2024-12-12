using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collision collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            Destroy(collision.gameObject);
        }

    }
}

