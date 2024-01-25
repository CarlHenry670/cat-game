using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peixinho : MonoBehaviour
{
    // Start is called before the first frame update

    private SpriteRenderer sr;
    private CircleCollider2D circle;
    public GameObject coletado;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            sr.enabled = false;
            circle.enabled = false;
            coletado.SetActive(true);

            Destroy(gameObject, 0.3f);
        }
    }


}
