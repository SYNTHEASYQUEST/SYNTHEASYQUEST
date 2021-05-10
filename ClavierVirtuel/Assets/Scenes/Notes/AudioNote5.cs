using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioNote5 : MonoBehaviour
{
   public AudioSource Note5;

    void Update()
    {
        if (Capteur.capteur == "0000 5000")
        {

            Note5.Play();
        }
    }
}
