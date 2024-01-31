// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Player2 : MonoBehaviour
// {

//     public float Speed;
//     public float JumpForce;

//     public bool isJumping;
//     public bool doubleJump;
//     private Rigidbody2D rig;

//     // Start is called before the first frame update
//     void Start()
//     {
//         rig = GetComponent<Rigidbody2D>();
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         Move();
//         Jump();
//     }

//     void Move()
//     {
//         Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
//         transform.position += movement * Time.deltaTime * Speed;
//     }

//     void Jump()
//     {
//         if (Input.GetButtonDown("Jump"))
//         {
//             if (!isJumping)
//             {
//                 rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
//                 doubleJump = true;
//             }
//             else
//             {
//                 if (doubleJump)
//                 {
//                     rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
//                     doubleJump = false;
//                 }
//             }

//         }
//     }

//     void OnCollisionEnter2D(Collision2D collision)
//     {
//         if (collision.gameObject.layer == 8)
//         {
//             isJumping = false;
//         }

//         if (collision.gameObject.tag == "espin")
//         {
//             Destroy(gameObject);
//             ControleJogo.instance.MostrarGameOver();
//         }
//     }

//     void OnCollisionExit2D(Collision2D collision)
//     {
//         if (collision.gameObject.layer == 8)
//         {
//             isJumping = true;
//         }
//     }
// }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    public float speed;
    public float jumpForce;

    public bool isJumping;
    public bool doubleJump;
    private Rigidbody2D rigidBody;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movee();
        Jumpi();
    }

    void Movee()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;
        if (Input.GetAxis("Horizontal") > 0f)
        {
            animator.SetBool("andar", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if (Input.GetAxis("Horizontal") < 0f)
        {
            animator.SetBool("andar", true);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
        if (Input.GetAxis("Horizontal") == 0f)
        {
            animator.SetBool("andar", false);
        }
    }

    void Jumpi()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (!isJumping)
            {
                rigidBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                doubleJump = true;
                animator.SetBool("pular", true);
            }
            else
            {
                if (doubleJump)
                {
                    rigidBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                    doubleJump = false;
                }
            }
        }
    }
}