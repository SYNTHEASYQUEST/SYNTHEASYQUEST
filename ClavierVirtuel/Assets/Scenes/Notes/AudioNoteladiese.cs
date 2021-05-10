using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioNoteladiese : MonoBehaviour
{
    public AudioSource Note11;

    void Update()
    {
        if (Capteur.capteur == "0002 0000")
        {

            Note11.Play();
        }
    }
}
