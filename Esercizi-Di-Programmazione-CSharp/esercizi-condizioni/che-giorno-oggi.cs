/*
  Che giorno è oggi?
  Scrivi un programma che dato un numero intero compreso tra 1 a 7
  visualizzi il corrispondente giorno della settimana. Sapendo che:
    1 = lunedì
    2 = martedì
    3 = mercoledì
    ...
    7 = domenica
  Utilizza il costrutto Switch-case e prevedi anche il caso in cui il valore immesso non sia valido
  (nel caso stampare un messaggio di errore a tua scelta).

  Esempi:
    Input: numero = 6
    Output: "Sabato"

    Input: numero = 10
    Output: "Errore! Giorno della settimana non valido!"

  Variante:
  Scrivere una versione che anziché i giorni della settimana, visualizzi i nomi dei mesi.

  http://www.imparareaprogrammare.it
*/

namespace esercizidiprogrammazione_csharp_WhatDayIsToday
{
    public class WhatDayIsToday
    {

        DaysOfTheWeek numero;
        string? result;
        public WhatDayIsToday()
        {

        }

        public void WhatDayIsTodaySolution()
        {
            inizializzaDescrizioneEsercizio();
            numero = ReadInput(numero);     
            result = PickDay(numero);
            PrintResult(result);
        }

        static private DaysOfTheWeek ReadInput(DaysOfTheWeek numero)
        {
            const string askNumber = "Inserisci un numero";
            const string retry = "Errore! Giorno della settimana non valido";
            Console.WriteLine(askNumber);
            while(!(Enum.TryParse<DaysOfTheWeek>(Console.ReadLine(), out numero)) || !(Enum.IsDefined<DaysOfTheWeek>(numero))) {
                Console.WriteLine(retry);
            }
            return numero;
        }

        static private String PickDay(DaysOfTheWeek numero) {
            String dayPicked;
            switch (numero)
            {
                case DaysOfTheWeek.MONDAY:
                    return DaysOfTheWeek.MONDAY.ToString();                   
                case DaysOfTheWeek.TUESDAY:
                    return DaysOfTheWeek.TUESDAY.ToString();                   
                case DaysOfTheWeek.WEDNESDAY:
                    return DaysOfTheWeek.WEDNESDAY.ToString();                   
                case DaysOfTheWeek.THURSDAY:
                    return DaysOfTheWeek.THURSDAY.ToString();                   
                case DaysOfTheWeek.FRIDAY:
                    return DaysOfTheWeek.FRIDAY.ToString();                  
                case DaysOfTheWeek.SATURDAY:
                    return DaysOfTheWeek.SATURDAY.ToString();                   
                case DaysOfTheWeek.SUNDAY:
                    return DaysOfTheWeek.SUNDAY.ToString();                  
                case DaysOfTheWeek.NOTDEFINED:
                    return DaysOfTheWeek.NOTDEFINED.ToString();                   
                default:
                    return DaysOfTheWeek.NOTDEFINED.ToString();                  
            }
        }

        static private void PrintResult(string result)
        {
            
            Console.WriteLine(result);
            return;
        }

        enum DaysOfTheWeek
        {
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY,
            SUNDAY,
            NOTDEFINED,
        }



        private void inizializzaDescrizioneEsercizio()
        {
            const string description = @"  Che giorno è oggi?
  Scrivi un programma che dato un numero intero compreso tra 1 a 7
  visualizzi il corrispondente giorno della settimana. Sapendo che:
    0 = lunedì
    1 = martedì
    2 = mercoledì
    ...
    6 = domenica
  Utilizza il costrutto Switch-case e prevedi anche il caso in cui il valore immesso non sia valido
  (nel caso stampare un messaggio di errore a tua scelta).

  Esempi:
    Input: numero = 6
    Output: Sabato

    Input: numero = 10
    Output: Errore! Giorno della settimana non valido!

  Variante:
            Scrivere una versione che anziché i giorni della settimana, visualizzi i nomi dei mesi.

            http://www.imparareaprogrammare.it";
            Console.Title = "Esercizio numero 2 : Quanti anni ha?";
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(description);
            Console.WriteLine(Environment.NewLine);
        }
    }
}