/*
  Pari o dispari?
  Scrivi un programma che prenda in input un numero intero e restituisca 0 se è pari o 1 se è dispari.

  Esempi:
    Input: numero = 63
    Output: 1

    Input: numero = 24
    Output: 0

  Consigli:
  Per capire se un numero è pari o dispari puoi usare un operatore, ma quale? :) 
  (Se non ti ricordi riguarda la lezione "Come dichiarare e definire le variabili e i tipi di dato" oppure "Il tipo Numero e gli operatori aritmetici")

  http://www.imparareaprogrammare.it
*/

namespace esercizidiprogrammazione_csharp_pariodispari
{
    public partial class PariODispari
    {
        int numero, risultato;
        public PariODispari()
        {
        }

        public void soluzionePariODispari()
        {
            inizializzaDescrizioneEsercizio();
            leggiInput(); // leggo l'input da console

            risultato = determinareOutput(numero); // calcolo il risultato 

            stampaRisultato(risultato); // stampo il risultato calcolato
        }

        private void leggiInput()
        {
            /* 
             * Leggo da console il numero, vado avanti solo
             * se quello che scrive l'utente è effettivamente un numero
             * usando la funzione TryParse per controllare
             * se l'input è convertibile in intero
             */
            Console.WriteLine($"Inserire numero : {numero}"); 
            while((!int.TryParse(Console.ReadLine(), out numero))) {
                Console.WriteLine("Inserito carattere non numerico, riprovare");

            }
        }

        private int determinareOutput(int numero)
        {
            /*
             * Devo determinare l'output del prorgamma.
             * Se il numero inserito è pari, vorrà dire che il suo risultato
             * modulo 2 è 0.
             * Se invece il numero inserito è dispari, il suo
             * risultato modulo 2 è 1.
             * Quindi controllo il risultato dell'operazione numero modulo 2
             * In base al risultato ritorno 0 o 1.
             */ 
            if (numero % 2 == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

        private void stampaRisultato(int risultato)
        {
            Console.WriteLine($"L'output è : {risultato}");
        }

        private void inizializzaDescrizioneEsercizio()
        {
            Console.Title = "Esercizio numero 2 : Quanti anni ha?";
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(@"
  Pari o dispari?
  Scrivi un programma che prenda in input un numero intero e restituisca 0 se è pari o 1 se è dispari.

  Esempi:
    Input: numero = 63
    Output: 1

    Input: numero = 24
    Output: 0

  Consigli:
  Per capire se un numero è pari o dispari puoi usare un operatore, ma quale? :) 
  (Se non ti ricordi riguarda la lezione Come dichiarare e definire le variabili e i tipi di dato oppure Il tipo Numero e gli operatori aritmetici)

  http://www.imparareaprogrammare.it

Soluzione scritta da Andrea Antonio Perrelli. © 2022. All rights reserved.
");
            Console.WriteLine(Environment.NewLine);
        }

    }
        

}
