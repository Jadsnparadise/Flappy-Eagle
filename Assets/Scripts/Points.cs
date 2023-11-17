using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour, ICountable<int>
{
    private GameController gameController;
    private AudioSource scoreSound;

    private void Start()
    {
        //como esse script est� em um objeto fora de cena � necess�rio que seja buscado o GameController do jogo sempre que o prefab for instanciado
       gameController =  FindObjectOfType<GameController>();                                                               
       scoreSound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider collision) // confere se o player passou pelos canos, toca o som e aumenta a pontua��o
    {
        scoreSound.Play();
        Increase(1);
        gameController.scoreText.text = gameController.playerScore.ToString();
    }

    public void Increase(int increaseIn) //Implementa��o do ICountable somando o score do player
    {
        gameController.playerScore += increaseIn;
    }
}
