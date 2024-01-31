using System.Collections;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    private Transform posicaoJogador;
    public float velocidadeDoInimigo;
    public float tempoDeEspera = 1.0f; 
    public string tagDoJogador = "Player";

    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag(tagDoJogador);

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
        StartCoroutine(MovimentoDoInimigo());
    }

    IEnumerator MovimentoDoInimigo()
    {
        yield return new WaitForSeconds(tempoDeEspera);

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
