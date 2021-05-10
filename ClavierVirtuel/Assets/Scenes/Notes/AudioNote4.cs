using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioNote4 : MonoBehaviour
{
    public AudioSource Note4;


    void Update()
    {

        if (Capteur.capteur == "0000 4000")
        {
            Note4.Play();
        }

    }
}
