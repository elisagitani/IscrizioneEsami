using System;
using System.Collections.Generic;
using System.Text;

namespace IscrizioneEsami
{
    public class Corso
    {
        public string NomeCorso { get; set; }
        public int CfuCorso { get; set; }

        public Corso()
        {

        }

        public Corso(string nomeCorso, int cfu)
        {
            NomeCorso = nomeCorso;
            CfuCorso = cfu;
        }


        public string GetInfo()
        {
            return $"{NomeCorso} \tCFU: {CfuCorso}";
        }
    }
}
