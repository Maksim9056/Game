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
        SceneManager.LoadScene(0); // ��������� ����� � �������� 1, ������� ����� ����� ������� ����
    }

    public void Menu()
    {
        SceneManager.LoadScene(0); // ��������� ������� ����
    }
}


