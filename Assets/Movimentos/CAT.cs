using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAT : MonoBehaviour
{
    public float vel;
    public float jumpForce;
    private Rigidbody2D rigi;

     public bool isJumpingo;
    public bool doubleJumpo;


    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Movew();
        pulin();
    }

    void Movew()
    {
        float horizontalInput = 0f;

        if (Input.GetKey("j"))
        {
            horizontalInput = -1f;
        }
        else if (Input.GetKey("k"))
        {
            horizontalInput = 1f;
        }

        Vector3 movement = new Vector3(horizontalInput, 0f, 0f);
        transform.position += movement * Time.deltaTime * vel;
    }

    void pulin()
    {
        if (Input.GetButtonDown("pulin"))  
        {
            if(!isJumpingo)
            {
                rigi.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                doubleJumpo = true;
            }
            else
            {
                if(doubleJumpo)
                {
                    rigi.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                    doubleJumpo = false;
                }
            }
        }
    }
}
