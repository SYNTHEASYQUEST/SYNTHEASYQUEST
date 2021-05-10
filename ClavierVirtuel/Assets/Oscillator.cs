using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
  public double frequency=440.0; // frequence produite par l'oscillateur
  private double increment; // variable qui va permettre de se placer sur l'axe des abscisses
  private double phase;  // variable qui va permettre de se placer sur l'axe des ordonnées
  private double sampling_frequency = 48000.0; // frequence generee par Unity par default
  public float gain; // Puissance, volume du son
  public int oscillator;

  public float volume =0.1f; // volume d'entree

  public double[] frequencies;
  public int thisFreq;

  // Nous allons ajouter des notes
  void Start() {
        frequencies=new double[21];
        frequencies[0]= 261.626; //Do3
        frequencies[1]= 293.665;
        frequencies[2]= 329.628;
        frequencies[3]= 349.228;
        frequencies[4]= 391.995;
        frequencies[5]= 440;
        frequencies[6]= 493.883;
        frequencies[7]= 523.251; //Do4
        frequencies[8]= 587.33;
        frequencies[9]= 659.255;
        frequencies[10]= 698.456;
        frequencies[11]= 783.991;
        frequencies[12]= 880;
        frequencies[13]= 987.767;
        frequencies[14]= 1046.5; //Do5
        frequencies[15]= 1174.66;
        frequencies[16]= 1318.51;
        frequencies[17]= 1396.91;
        frequencies[18]= 1567.98;
        frequencies[19]= 1760;
        frequencies[20]= 1975.53;
      
                
  }

  void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            gain =volume;
        }

        if (Input.GetKeyUp(KeyCode.Space)) {
            gain=0;
        }

        if (Input.GetKeyDown(KeyCode.A)) {
            frequency=frequencies[0];
        }

        if (Input.GetKeyUp(KeyCode.A)) {
            frequency=0;
        }

         if (Input.GetKeyDown(KeyCode.Z)) {
            frequency=frequencies[1];
        }

       
         if (Input.GetKeyDown(KeyCode.E)) {
            frequency=frequencies[2];
        }


         if (Input.GetKeyDown(KeyCode.R)) {
            frequency=frequencies[3];
        }

         if (Input.GetKeyDown(KeyCode.T)) {
            frequency=frequencies[4];
        }

         if (Input.GetKeyDown(KeyCode.Y)) {
            frequency=frequencies[5];
        }


         if (Input.GetKeyDown(KeyCode.U)) {
            frequency=frequencies[6];
        }

         if (Input.GetKeyDown(KeyCode.I)) {
            frequency=frequencies[7];
        }

         if (Input.GetKeyDown(KeyCode.O)) {
            frequency=frequencies[8];
        }

         if (Input.GetKeyDown(KeyCode.P)) {
            frequency=frequencies[9];
        }

         if (Input.GetKeyDown(KeyCode.Q)) {
            frequency=frequencies[10];
        }

         if (Input.GetKeyDown(KeyCode.S)) {
            frequency=frequencies[11];
        }

         if (Input.GetKeyDown(KeyCode.D)) {
            frequency=frequencies[12];
        }

         if (Input.GetKeyDown(KeyCode.F)) {
            frequency=frequencies[13];
        }

         if (Input.GetKeyDown(KeyCode.G)) {
            frequency=frequencies[14];
        }

         if (Input.GetKeyDown(KeyCode.H)) {
            frequency=frequencies[15];
        }

         if (Input.GetKeyDown(KeyCode.J)) {
            frequency=frequencies[16];
        }

         if (Input.GetKeyDown(KeyCode.K)) {
            frequency=frequencies[17];
        }

         if (Input.GetKeyDown(KeyCode.L)) {
            frequency=frequencies[18];
        }

         if (Input.GetKeyDown(KeyCode.M)) {
            frequency=frequencies[19];
        }

         if (Input.GetKeyDown(KeyCode.W)) {
            frequency=frequencies[20];
        }

        //Fonctionnalites pour le choix de l'oscillateur avec les touches de clavier
        
        if (Input.GetKeyDown(KeyCode.Keypad1)) {
            oscillator=1;
        }

         if (Input.GetKeyDown(KeyCode.Keypad2)) {
            oscillator=2;
        }

         if (Input.GetKeyDown(KeyCode.Keypad3)) {
            oscillator=3;
        }


        if (Input.GetKeyUp(KeyCode.Keypad0)) {
            oscillator=0;
        }

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
  }

}




      
