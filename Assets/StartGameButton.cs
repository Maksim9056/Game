using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    private bool isButtonActivated = false;

    public void OnButtonClick()
    {
        if (!isButtonActivated)
        {
            isButtonActivated = true;
            SceneManager.LoadScene(1);
        }
    }
}
