using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    float _timer = 0.0f;
    float _timeToChangeScene = 1.5f;

    bool _changeScene = false;

    public SoundEffectPlayer _soundEffectPlayer;

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _timeToChangeScene && _changeScene)
        {
            _timer = 0.0f;

            SceneManager.LoadScene("ShopGame");

            _changeScene = false;
        }
    }

    public void OnEnterGameplayScene()
    {
        //_soundEffectPlayer.PlaySoundEffect(_soundEffect);


        _soundEffectPlayer.PlaySoundEffect();

        _changeScene = true;
        //SceneManager.LoadScene("ShopGame");

    }

    public void OnQuit()
    {
        Application.Quit();
    }

    public void EnterExitScene() 
    {
        SceneManager.LoadScene("Ending");
    }

    public void EnterMenuScene()
    {
        SceneManager.LoadScene("Title");
    }

}
