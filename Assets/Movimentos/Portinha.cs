using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Portinha : MonoBehaviour
{

    public string nomelvl;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
     SceneManager.LoadScene(nomelvl);
        }

    
    }
}
