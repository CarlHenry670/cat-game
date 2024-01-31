using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ControleJogo : MonoBehaviour
{
 public GameObject gameOver;
public static ControleJogo instance;
  public TextMeshProUGUI scoreText; 
    public int TotalPontos;

      public int peixinhosColetados; 
    public int NumeroTotalPeixinhos; 
    void Start()
    {
        instance = this;
    }

    public void UpdateScore()
    {
        scoreText.text = TotalPontos.ToString();
    }


        public void ColetarPeixinho()
    {
        peixinhosColetados++;
        if (peixinhosColetados >= NumeroTotalPeixinhos) 
        {
            // Se todos os peixinhos foram coletados, ative a portinha ou faça qualquer ação necessária.
            Portinha.instance.AtivarPortinha();
        }

        UpdateScore();
    }

    public void MostrarGameOver()
    {
        gameOver.SetActive(true);
    }

    public void ReiniciarCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }

   

}
