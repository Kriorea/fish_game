using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour{

    public static SoundManager instance;

    [SerializeField]
    private AudioSource soundFX;
    [SerializeField]
    private AudioClip eatClip, gameOverClip;

    void Awake() {
        if (instance == null)
            instance = this;
    }

    public void EatSound() {
        soundFX.clip = eatClip;
        soundFX.Play();
    }
    public void GGSound() {
        soundFX.clip = gameOverClip;
        soundFX.Play();
    }
}