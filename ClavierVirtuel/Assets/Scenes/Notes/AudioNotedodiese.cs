using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioNotedodiese : MonoBehaviour
{
    public AudioSource Note9;

    void Update()
    {
        if (Capteur.capteur == "0000 9000")
        {

            Note9.Play();
        }
    }
}
