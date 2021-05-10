using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioNote3 : MonoBehaviour
{
   public AudioSource Note3;

    void Update()
    {
        if (Capteur.capteur == "0000 3000")
        {

            Note3.Play();
        }
    }
}
