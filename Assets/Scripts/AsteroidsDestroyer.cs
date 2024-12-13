using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            print("Fallo de destruccion");
            Destroy(collision.gameObject);
        }

    }
}

