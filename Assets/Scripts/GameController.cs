using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public static bool inGame = false;
    public const float INITIALSPEED = 2f;
    public int playerScore = 0;
    public TextMeshProUGUI scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    public static void gameOver(GameObject gameOverUI) //ativa o menu de game over, pausa o jogo e reseta a dificuldade para caso o jogador queira jogar novamente
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0;
        inGame = false;
        PipesMoviment.moveSpeed = INITIALSPEED;
    }

    public static void StartGame(GameObject gameTitle) //Desaparece com o titulo e a mensagem de como começar o jogo
    {
        gameTitle.SetActive(false);
        inGame = true;
    }
}
