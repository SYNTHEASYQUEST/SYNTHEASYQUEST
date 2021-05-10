using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioNotemidiese : MonoBehaviour
{
    public AudioSource Note12;

    void Update()
    {
        if (Capteur.capteur == "0003 0000")
        {

            Note12.Play();
        }
    }
}
