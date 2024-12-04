using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSpawner : MonoBehaviour
{
    [SerializeField] private GameObject shoot;
    [SerializeField] private Transform parentPos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 cannon = new Vector3(parentPos.position.x, parentPos.position.y, 0);

            // (Prefab a instnacias, posici�n inicial, rotaci�n inicial)
            // Quaternion.identity viene a ser rotaci�n 0
            Instantiate(shoot, cannon, Quaternion.identity);
        }
        
    }
}