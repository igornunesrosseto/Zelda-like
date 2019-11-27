using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip MainMenuMusic, coinSound, swordSlash, deathOgre, deathLog;
    static AudioSource audioSrc;


    // Start is called before the first frame update
    void Start()
    {
        MainMenuMusic = Resources.Load<AudioClip>("ChillMusic");
        coinSound = Resources.Load<AudioClip>("Bonus");
        swordSlash = Resources.Load<AudioClip>("swing");
        deathOgre = Resources.Load<AudioClip>("som_morte_ogro1");
        deathLog = Resources.Load<AudioClip>("som_morte_tronco1");
        swordSlash = Resources.Load<AudioClip>("swing");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "ChillMusic":
                audioSrc.PlayOneShot(MainMenuMusic);
                break;
            case "Bonus":
                audioSrc.PlayOneShot(coinSound);
                break;
            case "swing":
                audioSrc.PlayOneShot(swordSlash);
                break;
            case "som_morte_ogro1":
                audioSrc.PlayOneShot(deathOgre);
                break;
            case "som_morte_tronco1":
                audioSrc.PlayOneShot(deathLog);
                break;
        }
    }
}
