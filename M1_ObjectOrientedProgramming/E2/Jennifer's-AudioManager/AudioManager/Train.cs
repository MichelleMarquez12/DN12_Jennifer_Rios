using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace AudioManager
{
    //Hereda de la clase padre (Vehicle) con : todos los atributos, métodos, etc..
    public class Train : Vehicle
    {
        //para la comprobación del sobreescrito de metodos debe usarse la palabra reservada "override"
        //mostrara los metodos compatibles, y completara el método
        public override void Sounds()
        {
            //Para su uso de audio debe instanciarse con AudioFileReader
            AudioFileReader audioFile = new AudioFileReader("Resources/train.wav");
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
