/*
  Fai il professore
  Scrivi un programma che converta un voto numerico (v) in un giudizio seguendo questi parametri:
    v < 18: insufficiente
    18 <= v < 21: sufficiente
    21 <= v < 24: buono
    24 <= v < 27: distinto
    27 <= v <= 29: ottimo
    v = 30: eccellente
  Utilizza costrutto If.

  Esempio:
    Input: v = 29
    Output: Distinto

  Variante
  Realizzare una versione con il costrutto Switch-Case. In questo caso gestire anche il caso in cui il voto inserito non sia valido.

  http://www.imparareaprogrammare.it
*/


namespace esercizidiprogrammazione_csharp_DoTheProfessor
{
    public partial class DoTheProfessor 
    {
        int n;
        PossibleGrades grade;
        public DoTheProfessor()
        {

        }

        public void DoTheProfessorSolution()
        {
            inizializzaDescrizioneEsercizio();
            n = ReadInput();
            grade = DetermineVote(n);
            PrintResult();
        }

        private int ReadInput()
        {
            int n;
            Console.WriteLine("Inserisci voto numerico compreso tra 0 e 30");
            while(!(int.TryParse(Console.ReadLine(), out n)) || !(n >= 0 && n <= 30))
            {
                Console.WriteLine("Input sbagliato. Inserire voto numerico compreso tra 0 e 30");
            }

            return n;
        }

        private PossibleGrades DetermineVote(int n)
        {
            if (n<18)
            {
                return PossibleGrades.INSUFFICIENT;
            } 
            else if (n>=18 && n<21)
            {
                return PossibleGrades.SUFFICIENT;
            } 
            else if (n>=21 && n<24)
            {
                return PossibleGrades.GOOD;
            } 
            else if (n>=24 && n<27)
            {
                return PossibleGrades.DISTINCT;
            } 
            else if (n>=27 && n<=29)
            {
                return PossibleGrades.OPTIMAL;
            }
            else if (n==30)
            {
                return PossibleGrades.EXCELLENT;
            }
            else
            {
                return PossibleGrades.UNDEFINED;
            }
        }

        private void PrintResult()
        {
            Console.WriteLine($"The result of the exam is {grade.ToString()}");
        }

        enum PossibleGrades
        {
            INSUFFICIENT,
            SUFFICIENT,
            GOOD,
            DISTINCT,
            OPTIMAL,
            EXCELLENT,
            UNDEFINED
        }


        private void inizializzaDescrizioneEsercizio()
        {
            Console.Title = "Esercizio numero 2 : Quanti anni ha?";
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(@"
Quanti anni ha ?
Scrivi un programma che dato l'anno corrente e un anno di nascita determini:
  - l'età della persona,
  - quanti anni sono necessari per raggiungere i 100
Restituisca in output entrambi i risultati.

Esempio:
Input: anno corrente = 2018, anno di nascita = 1991
Ouput: età = 27, anni mancanti = 73

http://www.imparareaprogrammare.it

Soluzione scritta da Andrea Antonio Perrelli. © 2022. All rights reserved.
");
            Console.WriteLine(Environment.NewLine);
        }
    }
}