using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioNote2 : MonoBehaviour
{
    public AudioSource Note2;

    public void OnMouseDown()
    {
        Note2.Play();

    }

    /*
    void Update()
    {
        if (Capteur.capteur == "0000 2000")
        {

            Note2.Play();
        }
    }*/
}
