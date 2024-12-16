using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    private Animator animator;


    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        animator.SetBool("Rolling", Input.GetKeyDown(KeyCode.Space)); /* Este es bool */

        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetTrigger("Rollinger"); /* Este es trigger */

        }
    }
}
