/*
  Chi l'azzecca?
  Scrivi un programma che dati due numeri di due ipotetici giocatori,
  generi un numero casuale compreso tra 1 e 100 (zero escluso),
  verifichi se uno dei due giocatori ha azzeccato il numero casuale,
  e in caso contrario quale dei due si è avvicinato di più al numero.

  Esempio:
    Input: giocatore 1 = 5, giocatore 2 = 10
    Output: Numero casuale generato = 7
            "Nessuno dei due ha azzeccato il numero casuale, ma il giocatore 1 si è avvicinato di più!"

  Consigli:
  Per generare un numero casuale utlizza la funzione javascript Math.random() che restituisce un intervallo compreso tra 0 e 1.
  Il valore ottenuto dovrà essere convertito per ottenere un valore valido per il tuo intervallo, in questo modo:
    (Math.random() * (max-min) + min) ovvero, nel tuo caso:
    (Math.random() * (100-1) + 1)
  Ricordati che il valore dovrà essere intero quindi dovrai arrontondarlo usando Math.floor()

  http://www.imparareaprogrammare.it
*/

namespace esercizidiprogrammazione_csharp_GuessNumber
{
    public class GuessNumber
    {
        int n1, n2;
        int maxRandomValue;
        int randomGeneratedNumber;
        String? result;
        public GuessNumber()
        {

        }

        public void GuessNumberSolution()
        {
            inizializzaDescrizioneEsercizio();
            (n1, n2) = ReadInput();
            randomGeneratedNumber = GenerateNumber(maxRandomValue);
            DetermineWinner(n1, n2, randomGeneratedNumber);
        }

        private (int, int)ReadInput()
        {
            int n1, n2;
            const string askNumber = "Inserisci primo numero";
            const string wrongNumber = "Non hai inserito un numero, riprova";
            Console.WriteLine(askNumber);
            while(!(int.TryParse(Console.ReadLine(), out n1)))
            {
                Console.WriteLine(wrongNumber);
            }
            Console.WriteLine(askNumber);
            while (!(int.TryParse(Console.ReadLine(), out n2)))
            {
                Console.WriteLine(wrongNumber);
            }
            maxRandomValue = 101;

            return (n1, n2);
        }

        private int GenerateNumber(int maxRandomValue) 
        {
            int randomGeneratedNumber;

            Random random = new Random();
            randomGeneratedNumber = random.Next(maxRandomValue);

            return randomGeneratedNumber;
        }

        private void DetermineWinner(int n1, int n2, int randomGeneratedNumber)
        {
            if (n1 == randomGeneratedNumber)
            {
                const string firstPlayerWinner = "Il giocatore numero 1 ha indovinato il numero";
                PrintWinner(result = firstPlayerWinner);
            }
            else if (n2 == randomGeneratedNumber)
            {
                const string secondPlayerWinner = "Il giocatore numero 2 ha indovinato il numero";
                PrintWinner(result = secondPlayerWinner);
            }
            else
                DetermineWhoIsCloser(n1, n2, randomGeneratedNumber);


        }

        private void DetermineWhoIsCloser(int n1, int n2, int randomGeneratedNumber)
        {
            int n1Gap, n2Gap;
            n1Gap = n1 - randomGeneratedNumber;
            n2Gap = n2 - randomGeneratedNumber;

            (n1Gap, n2Gap) = makeSignPositive(n1Gap, n2Gap);

            if (n1Gap > n2Gap)
            {
                const string secondPlayerCloser = "Nessuno dei due ha azzeccato il numero casuale, ma il giocatore 2 si è avvicinato di più";
                PrintWinner(result = secondPlayerCloser);
            }
            else
            {
                const string firstPlayerCloser = "Nessuno dei due ha azzeccato il numero casuale, ma il giocatore 1 si è avvicinato di più";
                PrintWinner(result = firstPlayerCloser);
            }
        }

        private void PrintWinner(String result)
        {
            string winnerString = $"Numero casuale generato = {randomGeneratedNumber}";
            Console.WriteLine(winnerString);
            Console.WriteLine(result);
        }

        private (int, int) makeSignPositive(int n1, int n2)
        {
            int n1Positive, n2Positive;
            if (Math.Sign(n1) == -1)
                n1Positive = -(n1);
            else
                n1Positive = n1;
            if (Math.Sign(n2) == -1)
                n2Positive = -(n2);
            else
                n2Positive = n2;

            return (n1Positive, n2Positive);
        }

        private void inizializzaDescrizioneEsercizio()
        {
            const string titleConsole = "Esercizio numero 1 : Somma e Media";
            Console.Title = titleConsole;
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            const string description = @"
  Chi l'azzecca?
  Scrivi un programma che dati due numeri di due ipotetici giocatori,
  generi un numero casuale compreso tra 1 e 100 (zero escluso),
  verifichi se uno dei due giocatori ha azzeccato il numero casuale,
  e in caso contrario quale dei due si è avvicinato di più al numero.

  Esempio:
    Input: giocatore 1 = 5, giocatore 2 = 10
    Output: Numero casuale generato = 7
            Nessuno dei due ha azzeccato il numero casuale, ma il giocatore 1 si è avvicinato di più!

  Consigli:
            Per generare un numero casuale utlizza la funzione javascript Math.random() che restituisce un intervallo compreso tra 0 e 1.
  Il valore ottenuto dovrà essere convertito per ottenere un valore valido per il tuo intervallo, in questo modo:
    (Math.random() * (max - min) + min) ovvero, nel tuo caso:
            (Math.random() * (100 - 1) + 1)
  Ricordati che il valore dovrà essere intero quindi dovrai arrontondarlo usando Math.floor()

  http://www.imparareaprogrammare.it

            ";
            Console.WriteLine(description);
            Console.WriteLine(Environment.NewLine);
        }
    }


}
