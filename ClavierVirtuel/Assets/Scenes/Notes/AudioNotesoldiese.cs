using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioNotesoldiese : MonoBehaviour
{
    public AudioSource Note14;

    void Update()
    {
        if (Capteur.capteur == "0005 0000")
        {

            Note14.Play();
        }
    }
}
