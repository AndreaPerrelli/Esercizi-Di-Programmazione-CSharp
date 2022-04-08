/*
  Ti ricordi le tabelline?
  Scrivi un programma che dato un numero stampi la tabellina corrispondente.

  Esempio:
    Input: 5
    Output: 0 5 10 15 20 25 30 35 40 45 50

  http://www.imparareaprogrammare.it
*/

namespace esercizidiprogrammazione_csharp_CountTable
{


    public partial class CountTable
    {
        int numero;
        int[]? table;
        public CountTable()
        {

        }

        public void CountTableSolution()
        {
            inizializzaDescrizioneEsercizio();
            numero = readInput();
            table = generateTable(numero);
            printTable(table);
        }

        static private int readInput()
        {
            const string richiesta = "Inserire un numero";
            const string errore = "Non hai inserito un numero, riprova.";
            int numero;
            Console.WriteLine(richiesta);
            while (!(int.TryParse(Console.ReadLine(), out numero)))
            {
                Console.WriteLine(errore);
            }
            return numero;
        }

        static private int[] generateTable(int numero)
        {
            int[] table = new int[11];
            for (int i = 0; i <= 10; i++)
            {
                table[i] = numero * i;
            }
            return table;
        }

        static private void printTable(int[] table)
        {
            Console.WriteLine(Environment.NewLine);
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine(table[i]);
            }

        }

        static private void inizializzaDescrizioneEsercizio()
        {
            const string title = "Esercizio numero 14 : Ti ricordi le tabelline?";
            const string descriptionExercise = @"
   Ti ricordi le tabelline?
  Scrivi un programma che dato un numero stampi la tabellina corrispondente.

  Esempio:
    Input: 5
    Output: 0 5 10 15 20 25 30 35 40 45 50

  http://www.imparareaprogrammare.it

  Soluzione scritta da Andrea Antonio Perrelli. © 2022. All rights reserved.

";
            Console.Title = title;
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(descriptionExercise);
            Console.WriteLine(Environment.NewLine);
        }

    }
}


