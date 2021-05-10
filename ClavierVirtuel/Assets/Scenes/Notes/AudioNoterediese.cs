using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioNoterediese : MonoBehaviour
{
    public AudioSource Note13;

    void Update()
    {
        if (Capteur.capteur == "0004 0000")
        {

            Note13.Play();
        }
    }
}
