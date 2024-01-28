using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Portinha : MonoBehaviour
{
 public static Portinha instance; // Variável estática para acessar a portinha de outros scripts
  private bool portinhaAtivada = false; // Nova variável para rastrear se a portinha está ativada
    public string nomelvl;

    void Start()
    {
        instance = this;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && portinhaAtivada) // Se o jogador colidir com a portinha e ela estiver ativada
        {
            // Reinicie a cena
            SceneManager.LoadScene(nomelvl);
        }

    
    }

        public void AtivarPortinha()
    {
        portinhaAtivada = true;
        // Adicione aqui qualquer outra lógica que você queira ao ativar a portinha.
    }
}
