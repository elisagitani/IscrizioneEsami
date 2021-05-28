using System;
using System.Collections.Generic;
using System.Text;

namespace IscrizioneEsami
{
    public class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataDiNascita { get; set; } = new DateTime(2003, 05, 28);  //Metto come default che lo studente deve essere maggiorenne
        public Immatricolazione Immatricolazione { get; set; } = new Immatricolazione();
        public List<Esame> Esami { get; set; } = new List<Esame>();  //Lista Esami 
        public bool RichiestaDiLaurea { get { return VerificaRichiestaLaurea(); }  }

        public Studente()
        {

        }
        public Studente(string nome, string cognome, DateTime dataNascita, Immatricolazione immatricolazione)
        {
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataNascita;
            Immatricolazione = immatricolazione;
        }


        public int CalcoloCfu()
        {

            foreach (var item in Esami)
                if (item.Superato)
                {
                    Immatricolazione.CfuAccumulati += item.Corso.CfuCorso;
                }

             return Immatricolazione.CfuAccumulati;
        }

        public bool VerificaRichiestaLaurea()
        {
            bool richiestaLaurea = false;

            if (Immatricolazione.CfuAccumulati == Immatricolazione.CorsoDiLaurea.CfuTotali)
            {
                richiestaLaurea = true;
            }
            return richiestaLaurea;
        }

        public string GetInfo()
        {
            return $"Nome:{Nome} \nCognome:{Cognome} \nMatricola:{Immatricolazione.Matricola} \nDataInizio:{Immatricolazione.DataInizio.ToShortDateString()} \nCorso di Laurea:{Immatricolazione.CorsoDiLaurea.GetInfo()} \nCFU accumulati:{Immatricolazione.CfuAccumulati} \nFuoriCorso:{Immatricolazione.FuoriCorso}";
        }
    }
}
