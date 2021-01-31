using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{

    public float speed = 1f;
    public Rigidbody2D rb2d;
    public Animator animator;

    Vector2 movement;

    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
            SceneManager.LoadScene("Puzzle01");
        }

    }

    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Movement
        rb2d.MovePosition(rb2d.position + movement * speed * Time.fixedDeltaTime);

    }
}