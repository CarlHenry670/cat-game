using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    private Transform posicaoJogador;
    public float velocidadeDoInimigo;
    public string tagDoJogador = "Player"; // Tag do jogador, pode ser configurada no Inspector

    void Start()
    {
        // Encontrar o jogador usando a tag configurada
        GameObject player = GameObject.FindGameObjectWithTag(tagDoJogador);

        // Verificar se o jogador foi encontrado
        if (player != null)
        {
            posicaoJogador = player.transform;
        }
        else
        {
            Debug.LogError("Jogador não encontrado. Verifique se a tag do jogador está correta.");
        }
    }

    void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        if (posicaoJogador != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, posicaoJogador.position, velocidadeDoInimigo * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(tagDoJogador))
        {
            Destroy(collision.gameObject);
            ControleJogo.instance.ReiniciarCena("Level_1 2");
        }
    }
}
