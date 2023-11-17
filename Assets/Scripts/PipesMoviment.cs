using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMoviment : MonoBehaviour, ICountable<float>
{
    [SerializeField] public static float moveSpeed = 2;
    [SerializeField] private float speedUpBreak; //intervalo de tempo que é aumentada a velocidade

    private const float SPEEDINCREASE = 0.2f;
    private const float MAXSPEED = 7f;
    private float timerSpeed = 0;

    // Update is called once per frame
    void Update()
    {
        if (GameController.inGame)
        {
            transform.position += moveSpeed * Time.deltaTime * Vector3.back;

            if (timerSpeed >= speedUpBreak && moveSpeed <= MAXSPEED) //verifica se já deu o tempo de aumentar a velocidade e se ainda não chegou no MAXSPEED
            {
                Increase(SPEEDINCREASE);
                timerSpeed = 0;
            }
            timerSpeed += Time.deltaTime;
            
        }
        else
        {
            transform.position += Vector3.zero; //se não estiver em jogo os canos devem parar de se movimentar
        }
    }

    public void Increase(float increasesIn) //Implementa o ICountable para aumentar o movespeed dos canos
    {
        moveSpeed += increasesIn;
    }
}
