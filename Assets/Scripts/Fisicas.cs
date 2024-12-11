using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisicas : MonoBehaviour
{
    [SerializeField] private float force = 5;
    private Rigidbody2D rb;
    [SerializeField] private Color coloreado;
    private SpriteRenderer sp;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            sp.color = coloreado;
        }
    }
}
