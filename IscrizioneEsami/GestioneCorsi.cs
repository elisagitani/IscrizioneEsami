using System;
using System.Collections.Generic;
using System.Text;

namespace IscrizioneEsami
{
    public static class GestioneCorsi
    {
        public static List<Corso> corsiMatematica = new List<Corso>();
        public static List<Corso> corsiLettere = new List<Corso>();
        public static List<Corso> corsiFisica = new List<Corso>();
        public static List<Corso> corsiIngegneria= new List<Corso>();
        public static List<Corso> corsiInformatica = new List<Corso>();

        public static List<CorsoDiLaurea> corsiDiLaurea = new List<CorsoDiLaurea>();
        public static List<Studente> studenti = new List<Studente>();

        public static List<Corso> CaricaCorsiMatematica()
        {
            Corso c1 = new Corso("Analisi 1", 9);
            Corso c2 = new Corso("Geometria", 6);
            Corso c3 = new Corso("Fisica 1", 7);
            
            corsiMatematica.Add(c1);
            corsiMatematica.Add(c2);
            corsiMatematica.Add(c3);

            return corsiMatematica;
        }

        public static List<Corso> CaricaCorsiLettere()
        {
            Corso c5 = new Corso("Letteratura Italiana", 12);
            Corso c9 = new Corso("Storia", 14);
            Corso c6 = new Corso("Filosofia", 12);

            corsiLettere.Add(c5);
            corsiLettere.Add(c9);
            corsiLettere.Add(c6);

            return corsiLettere;
        }

        public static List<Corso> CaricaCorsiFisica()
        {
            Corso c3 = new Corso("Fisica 1", 7);
            Corso c4 = new Corso("Fisica 2", 12);
           
            corsiFisica.Add(c3);
            corsiFisica.Add(c4);

            return corsiFisica;
        }
        public static List<Corso> CaricaCorsiIngegneria()
        {
            Corso c1 = new Corso("Analisi 1", 9);
            Corso c2 = new Corso("Geometria", 6);
            Corso c7 = new Corso("Informatica", 12);
            
            corsiIngegneria.Add(c1);
            corsiIngegneria.Add(c2);
            corsiIngegneria.Add(c7);

            return corsiIngegneria;
        }
        public static List<Corso> CaricaCorsiInformatica()
        {
            Corso c7 = new Corso("Informatica", 12);
            Corso c8 = new Corso("Calcolatori", 10);
            corsiInformatica.Add(c7);
            corsiInformatica.Add(c8);

            return corsiInformatica;
        }


        public static List<CorsoDiLaurea> CaricaCorsiDiLaurea()
        {
            CorsoDiLaurea c1 = new CorsoDiLaurea(Nome.Matematica, 3, CaricaCorsiMatematica());
            CorsoDiLaurea c2 = new CorsoDiLaurea(Nome.Lettere, 5, CaricaCorsiLettere());
            CorsoDiLaurea c3 = new CorsoDiLaurea(Nome.Ingegneria, 3, CaricaCorsiIngegneria());
            CorsoDiLaurea c4 = new CorsoDiLaurea(Nome.Fisica, 2,CaricaCorsiFisica());
            CorsoDiLaurea c5 = new CorsoDiLaurea(Nome.Informatica, 4, CaricaCorsiInformatica());

            corsiDiLaurea.Add(c1);
            corsiDiLaurea.Add(c2);
            corsiDiLaurea.Add(c3);
            corsiDiLaurea.Add(c4);
            corsiDiLaurea.Add(c5);
            

            return corsiDiLaurea;
        }

        public static List<Studente> CaricaStudente()
        {
            CorsoDiLaurea corsoDiLaurea = new CorsoDiLaurea(Nome.Ingegneria);
            Immatricolazione immatricolazione = new Immatricolazione(new DateTime(2013, 10, 01), corsoDiLaurea);
            Studente s1 = new Studente("Elisa","Gitani", new DateTime(1995,01,02), immatricolazione);
            studenti.Add(s1);
            return studenti;
        }

        public static Studente IsAutenticato(string nome, string cognome, int matricola)
        {
            foreach (var item in studenti)
            {
                if (item.Nome == nome && item.Cognome == cognome && item.Immatricolazione.Matricola==matricola)
                {
                    item.GetInfo();
                    return item;
                }
            }
            return null;
        }

         
        


    }
}
