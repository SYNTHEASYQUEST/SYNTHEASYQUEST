using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioNote7 : MonoBehaviour
{
   public AudioSource Note7;

    void Update()
    {
        if (Capteur.capteur == "0000 7000")
        {

            Note7.Play();
        }
    }
}
