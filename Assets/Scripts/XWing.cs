using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
using UnityEngine.InputSystem;

public class XWing : MonoBehaviour
{
    [SerializeField, Range(0,5)] private float movementSpeed;
    [SerializeField] private Transform ship;
    private Vector2 moveInput;

    private float limitX = 8;
    private float limitY = 4;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveInput * movementSpeed * Time.deltaTime);

        if (moveInput != Vector2.zero) /* Esto hará que mire en la dirección en la que se jueve, para rotarlo vaya */
        {
            // Esto conserva la orientación tras soltar la tecla hacia donde estaba la ultima vez su UP, osea, el eje y en positivo, que se ha desorientado en su posición local
            //ship.up = moveInput;
        }
        checkCollision();
    }
        
    private void OnMove(InputValue input)
    {
        moveInput = input.Get<Vector2>();
    }

    private void checkCollision()
    {
        if (transform.position.x <= -limitX)
        {
            transform.position = new Vector3 (-limitX, transform.position.y, transform.position.z);
        }
        else if (transform.position.x >= limitX)
        {
            transform.position = new Vector3(limitX, transform.position.y, transform.position.z);
        }

        if (transform.position.y <= -limitY)
        {
            transform.position = new Vector3(transform.position.x, -limitY, transform.position.z);
        }
        else if (transform.position.y >= limitY)
        {
            transform.position = new Vector3(transform.position.x, limitY, transform.position.z);
        }

    }
}
