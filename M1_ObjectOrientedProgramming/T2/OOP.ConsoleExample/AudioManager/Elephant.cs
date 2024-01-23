using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
//Para la reproducción de los sonidos debe usarse su namespace del archivo NuGet package

namespace AudioManager
{
    //Hereda de la clase padre (Animal) con : todos los atributos, métodos, etc...
    public class Elephant : Animal
    {
        public override void AnimalSound()
        {
            //Para su uso de audio debe instanciarse con AudioFileReader
            AudioFileReader audioFile = new AudioFileReader("Resources/elephant.wav");
            //Se crea la instancia para su uso
            WaveOutEvent waveOutEvent = new WaveOutEvent();

            //Se inicializa
            waveOutEvent.Init(audioFile);
            //Para iniciar la reproduccion del audio se usa el evento Play
            waveOutEvent.Play();

            //Para permitir que el codigo permita la reproducción debe ciclarse
            while (waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                //mantiene al programa en espera los segundos que se marcan
                System.Threading.Thread.Sleep(500);
            }

            waveOutEvent.Dispose();
            audioFile.Dispose();
        }
    }
}
