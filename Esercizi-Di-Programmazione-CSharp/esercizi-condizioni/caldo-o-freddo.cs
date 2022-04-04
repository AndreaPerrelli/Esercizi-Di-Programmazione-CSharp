/*
  Caldo o freddo
  Scrivi un programma che dati sette valori relativi alle temperature della settimana
  stabilisca la giornata più calda e quella più fredda.

  Esempio:
    Input: a = 10, b = -2, c = 31, d = 22, e = 15, f = -6, g = 7
    Output: giornata più calda = 31, giornata più fredda = -6

  http://www.imparareaprogrammare.it
*/


namespace esercizidiprogrammazione_csharp_ColdOrHot
{
    public partial class ColdOrHot
    {
        Dictionary<string, int> weakTemperature;

        public ColdOrHot()
        {
        }

        public void ColdOrHotSolution()
        {
            inizializzaDescrizioneEsercizio();
            weakTemperature = readInput();
            printOutput(weakTemperature.Values.Max(), weakTemperature.Values.Min());
        }

        static private Dictionary<string, int> readInput()
        {
            int n;
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (DaysOfTheWeek dayOfTheWeek in Enum.GetValues<DaysOfTheWeek>())
            {
                Console.WriteLine($"Inserire temperatura del giorno {dayOfTheWeek}");
                while(!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Inserire un numero valido");
                }
                dictionary.Add(dayOfTheWeek.ToString(), n);
            }
            return dictionary;
        }
        static private void printOutput(int max, int min)
        {
            string output = $"giornata più calda = {max}, giornata più fredda = {min}";
            Console.WriteLine(output);
        }


        enum DaysOfTheWeek
        {
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY,
            SUNDAY
        }

        static private void inizializzaDescrizioneEsercizio()
        {
            const string description = @"   Caldo o freddo
  Scrivi un programma che dati sette valori relativi alle temperature della settimana
  stabilisca la giornata più calda e quella più fredda.

  Esempio:
    Input: a = 10, b = -2, c = 31, d = 22, e = 15, f = -6, g = 7
    Output: giornata più calda = 31, giornata più fredda = -6

  http://www.imparareaprogrammare.it";
            const string title = "Esercizio numero 2 : Quanti anni ha?";
            Console.Title = title;
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(description);
            Console.WriteLine(Environment.NewLine);
        }
    }


}

