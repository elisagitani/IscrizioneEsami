using System;
using System.Collections.Generic;

namespace IscrizioneEsami
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<CorsoDiLaurea> corsiDiLaurea = GestioneCorsi.CaricaCorsiDiLaurea();
            List<Corso> corsi = new List<Corso>();
            List<Studente> studenti = GestioneCorsi.CaricaStudente();

            Console.WriteLine("Inserisci il tuo nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo cognome: ");
            string cognome = Console.ReadLine();
            int matricola;
            do
            {
                Console.WriteLine("Inserisci la tua matricola: ");
            } while (!int.TryParse(Console.ReadLine(), out matricola) && matricola >= 4000);

            Studente stud = GestioneCorsi.IsAutenticato(nome, cognome, matricola);

            if (stud != null)
            {
                Console.WriteLine("\nBenvenuto Studente!");
                Console.WriteLine("\nEcco i tuoi dati: ");
                Console.WriteLine(stud.GetInfo());
            }
            else
            {
                Console.WriteLine("Non sei iscritto a nessun corso di laurea!");
            }

            do
            {
                Console.WriteLine("-------------------------------------------------Menù------------------------------------------------------");
                Console.WriteLine("1. Prenotare un esame");
                Console.WriteLine("2. Verbalizzare un esame");
                Console.WriteLine("0. Esci");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                
                int scelta;
                do
                {
                    Console.Write("Fai la tua scelta: ");

                } while (!int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta < 2);

                switch (scelta)
                {
                    case 1:
                        Nome nomeCorso = stud.Immatricolazione.CorsoDiLaurea.Nome;
                        if (nomeCorso == Nome.Ingegneria)
                        {
                            corsi = GestioneCorsi.corsiIngegneria;
                            Console.WriteLine("\nCorsi disponibili: ");   
                            foreach (var item in corsi)
                            {
                                
                                Console.WriteLine(item.GetInfo());
                            }

                                //Far vedere allo studente la lista di esami che può dare in base al suo corso di laurea
                                //Chiedere allo studente di scegliere quale esame prenotare in base al corso 
                               //Verificare il numero di crediti e aggiungere alla lista stud.Esami l'esame scelto
                            
                        }
                        break;
                    case 2:
                        //Metodo EsamePassato(Input:Esame prenotato)
                        //Impostare a true il valore di superato

                        break;
                    case 0:
                        return;
                }


            } while (true);
        }
    }
}
