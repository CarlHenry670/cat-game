using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma : MonoBehaviour
{

  public float speed;
    public float moveTime;

    private bool dirRight = true;
    private float timer;

    private Animator Anim;



    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);

        if(dirRight)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);

            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }

        if(timer >= moveTime)
        {
            dirRight = !dirRight;
            timer = 0;
        }
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        float height = col.contacts[0].point.y - transform.position.y;
        if(height > 0)
        {
            col.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 10, ForceMode2D.Impulse);
           speed = 0;
            Destroy(gameObject, 0.5f);
        } 

    }
}
