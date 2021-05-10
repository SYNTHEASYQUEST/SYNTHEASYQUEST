using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioNote1 : MonoBehaviour
{
    public AudioSource audio;
    
    void Start() {

        audio.mute = true;
    }

    // Update is called once per frame

    void Update()
    {

        if (Capteur.capteur == "0000 1000")
        {
            audio.PlayDelayed(4);
        }
    }
}