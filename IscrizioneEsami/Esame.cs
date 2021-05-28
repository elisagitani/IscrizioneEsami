using System;
using System.Collections.Generic;
using System.Text;

namespace IscrizioneEsami
{
    public class Esame
    {
        public Corso Corso { get; set; } = new Corso();         //Creo un oggetto corso vuoto
        public bool Superato { get; set; }

        public Esame()
        {
            
        }

        public Esame(Corso corso)
        {
            Corso = corso;
        }

        public string GetInfo()
        {
            return $"Corso: {Corso.NomeCorso} \tCFU:{Corso.CfuCorso} \tSuperato:{Superato}";
        }
    }
}
