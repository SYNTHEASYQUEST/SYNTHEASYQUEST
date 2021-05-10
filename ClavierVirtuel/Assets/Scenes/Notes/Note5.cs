using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note5 : MonoBehaviour
{

  // VARIABLES POUR LA CREATION DU SON
  public double frequency=392; // frequence produite par l'oscillateur
  private double increment; // variable qui va permettre de se placer sur l'axe des abscisses
  private double phase;  // variable qui va permettre de se placer sur l'axe des ordonnées
  private double sampling_frequency = 48000.0; // frequence generee par Unity par default
  public float gain; // Puissance, volume du son
  public int oscillator;
  public float volume =0.1f; // volume d'entree



    // Start is called before the first frame update
    void Start()
    {
        gain=1;
       
    }

    // Update is called once per frame
    void Update()
    {
        oscillator = VariableOscillo.variable;
        Debug.Log(oscillator);
    }

   

    void OnAudioFilterRead(float[] data, int channels) {

        increment = frequency*2.0* Mathf.PI / sampling_frequency; 

        if(oscillator==1) {
        
            for (var i = 0; i < data.Length; i = i + channels) {                  
            
                phase = phase + increment;  
                data[i]=(float)(gain * Mathf.Sin((float)phase));

                if (channels==2) {  //Pour les canaux du son 
                    data[i+1]=data[i];   // this is where we copy audio data to make them “available” to Unity
                }

                if (phase>(Mathf.PI*2)){   // On reset la phase quand on a fait 4 boucles
                    phase=0.0;
                }
        
            }
        }
        
        if(oscillator==2) {
            
        
            for (var i = 0; i < data.Length; i = i + channels) {                  
            
                phase = phase + increment;
                if(gain*Mathf.Sin((float)phase)>=0*gain) {
                    data[i]=(float)(gain * 0.6f);
                }

                else {
                    data[i]=(-(float)gain)*0.6f;
                }
           

                if (channels==2) {  //Pour les canaux du son 
                    data[i+1]=data[i];   // this is where we copy audio data to make them “available” to Unity
                }

                if (phase>(Mathf.PI*2)){   // On reset la phase quand on a fait 4 boucles
                    phase=0.0;
                }
        
            }
        }

         if(oscillator==3) {
        
            for (var i = 0; i < data.Length; i = i + channels) {                  
            
                phase = phase + increment;  
                data[i]=(float)(gain * (double) Mathf.PingPong((float)phase,1.0f));

                if (channels==2) {  //Pour les canaux du son 
                    data[i+1]=data[i];   // this is where we copy audio data to make them “available” to Unity
                }

                if (phase>(Mathf.PI*2)){   // On reset la phase quand on a fait 4 boucles
                    phase=0.0;
                }
        
            }
        }
  }

 
}




