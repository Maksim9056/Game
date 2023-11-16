using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(0); // Загружаем сцену с индексом 1, которая будет вашим главным меню
    }

    public void Menu()
    {
        SceneManager.LoadScene(0); // Загружаем главное меню
    }
}


