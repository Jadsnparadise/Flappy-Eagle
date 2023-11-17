using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject pipe;
    [SerializeField] private float height;//height to make the procedural generation of the pipes. 
    [SerializeField] private float maxTime;// break up to spawn a pipe
    
    private float timerSpawn = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }



    // se o jogo tiver começado será spawnado os canos a cada MaxTime segundos
    void Update()
    {
        if (GameController.inGame)
        {
            if (timerSpawn > maxTime)
            {
                GameObject newPipe = Spawn();
                Destroy(newPipe, 8f);
                timerSpawn = 0;
            }
            timerSpawn += Time.deltaTime;
            
        }
    }
        

    

    private GameObject Spawn() // retornao o objeto configurado para ser spawnado
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        return newPipe;
    }
}

