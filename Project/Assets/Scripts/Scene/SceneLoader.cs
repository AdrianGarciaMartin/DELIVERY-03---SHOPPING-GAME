using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void OnEnterGameplayScene()
    {

        SceneManager.LoadScene("ShopGame");

    }

    public void OnQuit()
    {
        Application.Quit();
    }

    public void EnterExitScene() //implementarlo más adelante
    {
        SceneManager.LoadScene("Ending");
    }

}
