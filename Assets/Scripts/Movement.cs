using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 4f;
    public float CrouchSpeed = 3.5f;
    public float jumpSpeed = 50f;
    public bool isGrounded;
    public bool Crouch;
    BoxCollider2D boxColliderComponent;
    public Animator animator;

    void Start()
    {
        boxColliderComponent = GameObject.Find("Player").GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) && Crouch == false)
        {
            transform.position += Vector3.left * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) && Crouch == false)
        {
            transform.position += Vector3.right * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) && Crouch == true)
        {
            transform.position += Vector3.left * CrouchSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) && Crouch == true)
        {
            transform.position += Vector3.right * CrouchSpeed * Time.deltaTime;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown("space") && isGrounded == true && Crouch == false)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpSpeed);
            isGrounded = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Crouch = true;
            boxColliderComponent.enabled = false;
            animator.SetBool("Crouch", true);

        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            Crouch = false;
            boxColliderComponent.enabled = true;
            animator.SetBool("Crouch", false);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
    }
}
