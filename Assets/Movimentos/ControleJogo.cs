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
    void Start()
    {
        instance = this;
    }

    public void UpdateScore()
    {
        scoreText.text = TotalPontos.ToString();
    }

    public void MostrarGameOver()
    {
        gameOver.SetActive(true);
    }

    public void ReiniciarCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);


    }

    // Update is called once per frame

}
