using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ControleJogo : MonoBehaviour
{
    // Start is called before the first frame update
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

    // Update is called once per frame

}
