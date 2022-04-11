/*
  Rombo che stampa!
  Scrivi un programma che dato un numero dispari stampi un rombo di lettere.

  Esempio:
    Input : 5
    Output:
            X
           XXX
          XXXXX
           XXX
            X

  Consiglio:
  Per indentare puoi usare il tab con '\t'.
  
  http://www.imparareaprogrammare.it
*/

namespace esercizidiprogrammazione_csharp_PrintingRhombus
{
    public partial class PrintingRhombus
    {
        private int input;
        public PrintingRhombus()
        {
            input = 0;
        }
        public void PrintingRhombusSolution()
        {
            inizializzaDescrizioneEsercizio();
            input = readInput();
            printRhombus(input);
        }

        static private int readInput()
        {
            int input;
            Console.WriteLine("Inserire come input un numero dispari");
            while (!(int.TryParse(Console.ReadLine(), out input)) && input % 2 == 0)
            {
                Console.WriteLine("Riprova. Non hai inserito un numero dispari");
            }
            return input;

        }

        static private void printRhombus(int input)
        {
            int i;
            const string rhombus = "X";
            for (i = 1; i <= input; i++)
            {
                if (i == 1)
                    Console.WriteLine(rhombus);
                if (i == 2)
                    Console.WriteLine(rhombus + rhombus + rhombus);
                if (i == 3)
                    Console.WriteLine(rhombus + rhombus + rhombus + rhombus + rhombus);
                if (i == 4)
                    Console.WriteLine(rhombus + rhombus + rhombus);
                if (i == 5)
                    Console.WriteLine(rhombus);
            }
        }

        private void inizializzaDescrizioneEsercizio()
        {
            const string Title = "Esercizio numero 15 : Rombo che stampa";
            const string Description = @"
    Rombo che stampa!
  Scrivi un programma che dato un numero dispari stampi un rombo di lettere.

  Esempio:
    Input : 5
    Output:
            X
           XXX
          XXXXX
           XXX
            X

  Consiglio:
  Per indentare puoi usare il tab con '\t'.
  
  http://www.imparareaprogrammare.it

  Soluzione scritta da Andrea Antonio Perrelli. © 2022. All rights reserved.

";
            Console.Title = Title;
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Description);
            Console.WriteLine(Environment.NewLine);
        }
    }

}
