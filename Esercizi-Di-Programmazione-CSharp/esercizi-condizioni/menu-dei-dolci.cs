/*
  Menu dei dolci
  Scrivi un programma che dato il seguente menu (da stampare):
    MENU:
    1. Tiramisù
    2. Torta della nonna
    3. Cheesecake alla nutella
    4. Macedonia

  Prenda in input un valore numerico che rappresenti la scelta e restituisca:
    - se la scelta non è tra quelle elencate la scritta 'Dolce non disponibile',
    - altrimenti la scelta effettuata 'Hai scelto il dolce X'.


  Esempi:
    Input: scelta = 4
    Output: Hai scelto il dolce Macedonia

    Input: scelta = 7
    Output: Dolce non disponibile

  http://www.imparareaprogrammare.it
*/

namespace esercizidiprogrammazione_csharp_CakeMenu
{
    public partial class CakeMenu
    {
        private Menù scelta;
        public CakeMenu()
        {

        }


        public void CakeMenuSolution()
        {
            inizializzaDescrizioneEsercizio();
            printMenu();
            scelta = readInput();
            printResult(scelta);
        }


        private void printMenu()
        {
            Console.WriteLine(@"    MENU:
    0.Tiramisù
    1.Torta della nonna
    2.Cheesecake alla nutella
    3.Macedonia");
        }

        private Menù readInput()
        {
            Console.WriteLine("Inserire numero sceltà del menù");
            while (!(Enum.TryParse<Menù>(Console.ReadLine(), out scelta)) || !(Enum.IsDefined(typeof(Menù), scelta)))
            {
                Console.WriteLine("Dolce non disponibile");
            }
            return scelta;

        }

        private void printResult(Menù scelta)
        {
            Console.WriteLine($"Hai scelto il dolce {scelta.ToString()}");
        }

        private void inizializzaDescrizioneEsercizio()
        {
            // printing description of exercise
            Console.Title = "Esercizio numero 1 : Somma e Media";
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(@"
  Menu dei dolci
  Scrivi un programma che dato il seguente menu (da stampare):
    MENU:
    1. Tiramisù
    2. Torta della nonna
    3. Cheesecake alla nutella
    4. Macedonia

  Prenda in input un valore numerico che rappresenti la scelta e restituisca:
    - se la scelta non è tra quelle elencate la scritta 'Dolce non disponibile',
    - altrimenti la scelta effettuata 'Hai scelto il dolce X'.


  Esempi:
    Input: scelta = 4
    Output: Hai scelto il dolce Macedonia

    Input: scelta = 7
    Output: Dolce non disponibile

  http://www.imparareaprogrammare.it

  Soluzione scritta da Andrea Antonio Perrelli. © 2022. All rights reserved.

");
        }

        enum Menù
        {
            TIRAMISU,
            GRANDMOTHERS_CAKE,
            NUTELLA_CHEESECAKE,
            FRUIT_SALAD
        }
    }
}
