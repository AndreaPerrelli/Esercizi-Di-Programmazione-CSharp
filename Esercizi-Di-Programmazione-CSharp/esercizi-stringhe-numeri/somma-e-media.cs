/*
  Somma e media
  Scrivi un programma che dati 5 numeri restituisca in output la somma e la media.

  Esempio:
    Input: a = 1, b = 2, c = 3, d = 4, e = 5
    Output: somma = 15, media = 3
  
  http://www.imparareaprogrammare.it
*/


namespace esercizidiprogrammazione_csharp_sommaemedia;

public class SommaEMedia {

    int somma;
    float media;
    Dictionary<string, int>? chiaveValoreInsieme { get; set; }
    bool numeroInseritoNonèValido;

    public void soluzioneSommaEMedia()
    {
        inizializzaVariabili();
        leggiNumeri();
        calcoloSommaEMedia();

    }

    private void leggiNumeri()
    {
        int n;

        if (chiaveValoreInsieme != null)
        {
            foreach (var chiave in chiaveValoreInsieme)
            {
                Console.WriteLine($"Inserire il numero {chiave.Key} :");
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    numeroInseritoNonèValido = true;
                    stampa(chiave.Key);

                }
                numeroInseritoNonèValido = false;
                chiaveValoreInsieme[chiave.Key] = n;

            }
        }
    }


    private void inizializzaVariabili()
    {
        somma = 0; media = 0;
        chiaveValoreInsieme = new Dictionary<string, int>();
        chiaveValoreInsieme.Add("a", 0); chiaveValoreInsieme.Add("b", 0); chiaveValoreInsieme.Add("c", 0); chiaveValoreInsieme.Add("d", 0); chiaveValoreInsieme.Add("e", 0);
    }

    private void calcoloSommaEMedia()
    {
        int indiceMedia = 1;
        // calcolo somma
        if (chiaveValoreInsieme != null)
        {
            foreach (var valore in chiaveValoreInsieme)
            {
                somma += valore.Value;
                indiceMedia++;
            }
            indiceMedia--;

            media = somma / indiceMedia;
        }
        stampa("");
    }

    private void stampa(String numero)
    {
        if (numeroInseritoNonèValido == true && numero != null)
        {
            Console.WriteLine("Hai inserito un numero sbagliato");
            Console.WriteLine($"Inserire il numero {numero} :");
            return;
        }
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine($"Il risultato della somma dei numeri è : {somma}");
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine($"Il risultato della media della somma è : {media}");
        Console.WriteLine(Environment.NewLine);
    }


}
