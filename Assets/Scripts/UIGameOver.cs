using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIGameOver : MonoBehaviour, IClickable
{
    [SerializeField] private Button restartButton;

    void Awake()
    {
        restartButton.onClick.AddListener(OnbuttonPlayClick);
        
    }
    public void OnbuttonPlayClick() //Implementa a IClickable, reseta o jogo caso tenha clicado no botão
    {
        SceneManager.LoadScene(0);
    }
}
