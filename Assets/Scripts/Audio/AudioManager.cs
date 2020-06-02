using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musique;
    private float AudioFadeInTimer = 2f;
    private float AudioFadeOutTimer = 4f;
    private bool activeFadeIn;
    private bool activeFadeOut;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (activeFadeIn == true)
        {
            musique.volume = 0;
            AudioFadeInTimer -= Time.deltaTime;
            if (AudioFadeInTimer > 0)
            {
                musique.volume += 0.55f;
            }
            else
            {
                musique.volume = 1;
                activeFadeIn = false;
            }
            // Debug.Log("AudioFadeTimer : " + AudioFadeInTimer);
        }

        if (activeFadeOut == true)
        {
            musique.volume = 1;
            AudioFadeOutTimer -= Time.deltaTime;
            if (AudioFadeOutTimer > 0)
            {
                musique.volume -= 0.7f;
                // Debug.Log("-0.7 !");
            }
            else
            {
                musique.volume = 0;
                activeFadeOut = false;
            }
            // Debug.Log("AudioFadeTimer : " + AudioFadeOutTimer);
        }
    }


    public void ChangeMusic(AudioClip music)
    {
        // AudioFadeTimer = 2f;
        // musique.volume = 0;

        activeFadeIn = true;
        musique.Stop();
        musique.clip = music;
        musique.Play();
    }
}
