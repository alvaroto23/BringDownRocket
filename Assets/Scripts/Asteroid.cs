using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GridBrushBase;

public class Asteroid : MonoBehaviour
{

    [SerializeField] private float asteroidSpeed = 2;

    void Update()
    {

        transform.position += new Vector3(0, -asteroidSpeed * Time.deltaTime, 0);
        //transform.Rotate(0, 0, rotationDirection * Time.deltaTime);

        //if (transform.position.y >= 10)
        //{
        //    Destroy(gameObject);
        //}

    }
}

