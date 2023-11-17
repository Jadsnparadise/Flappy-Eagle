using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMoviment : MonoBehaviour
{
    [SerializeField] private int jumpHeight;
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject gameTitleImg;

    //private CharacterController player;
    private Animator anim;
    private Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();//
        player.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        //verifica se o jogo ja começou e se foi pressionado o espaço
        if(!GameController.inGame && Input.GetKeyDown(KeyCode.Space))
        {
            GameController.StartGame(gameTitleImg);
            player.useGravity = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {        
            Jump();           
        }

    }

    private void Jump()
    {
        player.velocity = jumpHeight * Vector3.up;

    }


    private void Die()
    {
        anim.SetBool("isDead", true);
        
    }

    private void OnCollisionEnter(Collision collision) //confere se o player colidiu com um cano
    {
        Die();
        GameController.gameOver(gameOverUI); //chama o menuGameOver caso tenha colidido
    }

    
}

