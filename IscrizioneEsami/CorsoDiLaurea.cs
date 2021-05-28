using System;
using System.Collections.Generic;
using System.Text;

namespace IscrizioneEsami
{
    public enum Nome
    {
        Matematica=1,
        Fisica=2,
        Informatica=3,
        Ingegneria=4,
        Lettere=5
    }
    public class CorsoDiLaurea
    {
        public Nome Nome { get; set; }
        public int AnniDiCorso { get; set; }
        public int CfuTotali { get { return CalcoloCfuTotali(); }  }
        public List<Corso> Corsi { get; set; } = new List<Corso>();  //Creo una lista di corsi vuota


        public int CalcoloCfuTotali()
        {
            int cfuTotali=0;
            foreach (var item in Corsi)     //Scorro la lista corsi e prendo i relativi cfu e li inserisco in una variabile di appoggio
            {
                cfuTotali += item.CfuCorso;
            }

            return cfuTotali;
        }


        public CorsoDiLaurea()
        {

        }
        public CorsoDiLaurea(Nome nome)
        {
            Nome = nome;
        }
        public CorsoDiLaurea(Nome nome, int anni, List<Corso> corsi)
        {
            Nome = nome;
            AnniDiCorso = anni;
            Corsi = corsi;
        }

        public void StampaInfoCorsi()
        {
           
            Console.WriteLine($"Nome Corso di Laurea: {Nome}");
            Console.WriteLine($"Anni di corso: {AnniDiCorso}");
            Console.WriteLine($"CFU Totali: {CfuTotali}");
            Console.WriteLine("\nCorsi che devono essere sostenuti per il conseguimento del titolo: ");
            foreach(var item in Corsi)
            {
                Console.WriteLine($"\n{item.GetInfo()}");
            }
            Console.WriteLine("----------------------------------------------------------------------");
        }

        public string GetInfo()
        {
            return $"{Nome}";
        }
    }
}
