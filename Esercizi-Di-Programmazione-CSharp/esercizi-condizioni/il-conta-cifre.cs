/*
  Il conta cifre
  Scrivi un programma che dato un numero (massimo 9999) conti da quante cifre è formato.

  Esempi:
    Input: numero = 9
    Output: 1 cifra

    Input: numero = 245
    Output: 3 cifre

  http://www.imparareaprogrammare.it
*/

namespace esercizidiprogrammazione_csharp_CountDigits
{
    public partial class CountDigits
    {
        int number;
        int digits;

        public CountDigits()
        {

        }

        public void CountDigitsSolution()
        {
            inizializzaDescrizioneEsercizio();
            number = readInput();
            digits = calculateDigits(number);
            printResult(digits);
        }

        private int readInput()
        {
            int number;
            Console.WriteLine("Enter a number :");
            while (!(int.TryParse(Console.ReadLine(), out number)))
            {
                Console.WriteLine("Not a number. Retry!");
            }

            return number;
        }

        private int calculateDigits(int number)
        {
            if (number >= 0 && number <= 9)
            {
                digits = 1;
            }
            else if (number >= 10 && number <= 99)
            {
                digits = 2;
            }
            else if (number >= 100 && number <= 999)
            {
                digits = 3;
            }
            else if (number >= 1000 && number <= 9999)
            {
                digits = 4;
            }
            else
            {
                digits = 5;
            }
            return digits;
        }

        private void printResult(int digits)
        {
            if (digits != 5)
            {
                Console.WriteLine($"Il numero inserito ha {digits} cifre. ");
            }
            else
            {
                Console.WriteLine("Il numero inserito ha più di 4 cifre.");
            }
        }


        private void inizializzaDescrizioneEsercizio()
        {
            // printing description of exercise
            Console.Title = "Esercizio numero 1 : Somma e Media";
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(@"
  Il conta cifre
  Scrivi un programma che dato un numero (massimo 9999) conti da quante cifre è formato.

  Esempi:
    Input: numero = 9
    Output: 1 cifra

    Input: numero = 245
    Output: 3 cifre

  http://www.imparareaprogrammare.it

  Soluzione scritta da Andrea Antonio Perrelli. © 2022. All rights reserved.

");
            Console.WriteLine(Environment.NewLine);
        }

    }
}
