using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GridBrushBase;

public class Asteroid : MonoBehaviour
{

    [SerializeField] private float asteroidSpeed = 2;

    private void OnCollisionEnter2D(Collision collision)
    {
        if (collision.gameObject.CompareTag("XWing"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Shoot"))
        {
            Destroy(gameObject);
        }

    }


    void Update()
    {

        transform.position += new Vector3(0, -asteroidSpeed * Time.deltaTime, 0);
        //transform.Rotate(0, 0, rotationDirection * Time.deltaTime);
        
    }
}

