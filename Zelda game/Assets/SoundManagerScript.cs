using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip MainMenuMusic, coinSound;
    static AudioSource audioSrc;


    // Start is called before the first frame update
    void Start()
    {
        MainMenuMusic = Resources.Load<AudioClip>("ChillMusic");
        coinSound = Resources.Load<AudioClip>("Bonus");

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
        }
    }
}
