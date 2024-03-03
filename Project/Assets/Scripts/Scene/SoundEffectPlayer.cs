using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectPlayer : MonoBehaviour
{
    public AudioSource _soundEffect;

    public void PlaySoundEffect()
    {
        _soundEffect.Play();
    }
}
