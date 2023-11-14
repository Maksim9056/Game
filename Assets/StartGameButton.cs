using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{

    //string sceneName = "Assets/Scenes/SampleSceneunity";

    //string FirstsceneName = "MainScene";
    //public float delay = 20f; // Задержка в секундах

   public void Startgame()
   {

           SceneManager.LoadScene(1);
        

   }

 
}