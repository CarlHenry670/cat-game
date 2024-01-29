using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAT : MonoBehaviour
{
    // Start is called before the first frame update

    public float vel;
    public float jumpForce2;
    private Rigidbody2D rigi;

    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
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
    void pulin(){
        if(Input.GetButtonDown("Jump")){
            rigi.AddForce(new Vector2(0f, 10f), ForceMode2D.Impulse);
        }
}
}
