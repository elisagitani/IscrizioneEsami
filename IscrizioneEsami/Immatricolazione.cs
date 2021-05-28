using System;
using System.Collections.Generic;
using System.Text;

namespace IscrizioneEsami
{
    public class Immatricolazione
    {

        public static int numero = 4000;
        public int Matricola { get;  }
        public DateTime DataInizio { get; set; } = DateTime.Today;
        public CorsoDiLaurea CorsoDiLaurea { get; set; } = new CorsoDiLaurea(); 
        public bool FuoriCorso { get {return ControlloFuoriCorso(); } }
        public int CfuAccumulati { get; set; }

        public Immatricolazione()
        {
            
        }

        public Immatricolazione(DateTime data, CorsoDiLaurea corsoDiLaurea)
        {
            DataInizio = data;
            Matricola = numero++;
            CorsoDiLaurea = corsoDiLaurea;
        }

        public bool ControlloFuoriCorso()
        {
            bool fuoricorso=true;
            var tempo = DateTime.Today - DataInizio;   //Calcolo intervallo di tempo che intercorre tra la data odierna e la data di immatricolazione
            int giorni = tempo.Days;  //Calcolo i giorni 
            //Converto Giorni in anni
            int anni = (int)(0.00273973 * giorni);
            if (anni < CorsoDiLaurea.AnniDiCorso)
            {
                fuoricorso = false;
            }
               
            return fuoricorso;
        }

       

    }
}
