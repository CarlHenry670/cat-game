using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serra : MonoBehaviour
{
  public float velocidade;
  public float MoveSerra;  

  private bool direcaoD = true;
  private float tempo;


    void Update()
    {
        if (direcaoD)
        {
            transform.Translate(Vector2.right * velocidade * Time.deltaTime);

        }
             else 
        {
            transform.Translate(Vector2.left * velocidade * Time.deltaTime);
        }

        tempo += Time.deltaTime;
        if(tempo >= MoveSerra)
        {
            direcaoD = !direcaoD;
            tempo = 0f;
        }
    }
}
