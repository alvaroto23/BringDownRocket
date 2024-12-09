using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    [SerializeField] private float shootSpeed = 6;
    private AudioSource audioController;
    [SerializeField] private AudioClip shootClip;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, shootSpeed * Time.deltaTime, 0);
        audioController.PlayOneShot(shootClip);

        if (transform.position.y >= 10)
        {
            Destroy(gameObject);
        }
        
    }
}
