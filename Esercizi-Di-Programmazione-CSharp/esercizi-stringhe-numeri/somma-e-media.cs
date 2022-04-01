/*
  Somma e media
  Scrivi un programma che dati 5 numeri restituisca in output la somma e la media.

  Esempio:
    Input: a = 1, b = 2, c = 3, d = 4, e = 5
    Output: somma = 15, media = 3
  
  http://www.imparareaprogrammare.it
*/



/*
  Soluzione scritta da Andrea Antonio Perrelli. © 2022. All rights reserved.
*/


namespace esercizidiprogrammazione_csharp_sommaemedia;

public class SommaEMedia {

    float somma; // somma da restituire in output
    float media; // media da restituire in output
    Dictionary<string, int>? chiaveValoreInsieme { get; set; } // Dizionario in cui mi salvo coppia {nomenumero - valorenumero}
    bool numeroInseritoNonèValido; // variabile di controllo per scanner dei numeri.

    public void soluzioneSommaEMedia()
    {
        inizializzaVariabili(); // chiamo il metodo di inizializzazione delle variabili
        leggiNumeri(); // chiamo il metodo di lettura dei numeri
        calcoloSommaEMedia(); // chiamo il metodo di calcolo della somma e della media dei numeri letti.

    }

    private void leggiNumeri()
    {
        int n; // valore che andrà a contenere il numero letto da console

        if (chiaveValoreInsieme != null) // mi assicuro che il dizionario chiaveValoreInsieme sia stato inizializzato.
        {
            /* Tramite il costrutto foreach, per ogni coppia nome-valore nel dizionario chiaveValoreInsieme, vado ad eseguire la lettura del numero 
               e lo salvo all'internod el dizionario come valore del nome corrispondente.
               Tramite il costrutto while, Finchè il valore inserito a console dall'utente non è corretto (non è un numero)
               vado a valorizzare la mia variabile di controllo numeroInseritoNonValido a true, per poi chiamare
               il metodo stampa che mi permette di mostrare a schermo l'errore e richiedere che venga inserito un valore numerico. 
            */
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
        somma = 0; media = 0; // inizializzo le variabili somma e media assegnando il valore 0 .
        chiaveValoreInsieme = new Dictionary<string, int>(); // inizializzo il dizionario chiaveValoreInsieme come dizionario vuoto.
        chiaveValoreInsieme.Add("a", 0); chiaveValoreInsieme.Add("b", 0); chiaveValoreInsieme.Add("c", 0); chiaveValoreInsieme.Add("d", 0); chiaveValoreInsieme.Add("e", 0);
        //vado ad assegnare al dizionario chiaveValoreInsieme dei valori aggiungendo 5 coppie di nomevalore.
    }

    private void calcoloSommaEMedia()
    {
        float indiceMedia = 1; //indice con cui mi salvo il valore dei numeri addizionati in modo da sapere per quanto dovrò dividere per avere la media.
        // calcolo somma
        // controllo che il dizionario chiaveValoreInsieme non sia vuoto, quindi che ci siano i numeri da addizionare.
        if (chiaveValoreInsieme != null)
        {
            /*Tramite il costrutto foreach, per ogni elemento del dizionario chiaveValoreInsieme, aggiungo il valore del singolo elemento
              alla variabile somma, e aumento di 1 il valore dei numeri addizionati.
            */
            foreach (var valore in chiaveValoreInsieme)
            {
                somma += valore.Value; 
                indiceMedia++;
            }
            indiceMedia--; // poichè avevo inizializzato indiceMedia ad 1, per avere il corretto valore di numeri addizionati sottraggo il risultato per uno.

            media = somma / indiceMedia; // calcolo la media dividendo la somma per il numero di operatori addizionati.
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
        Console.WriteLine($"Il risultato della media della somma è : {media:F3}");
        Console.WriteLine(Environment.NewLine);
    }


}
