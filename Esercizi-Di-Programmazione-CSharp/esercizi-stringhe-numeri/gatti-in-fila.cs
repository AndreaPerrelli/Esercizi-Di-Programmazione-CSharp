/*
  Gatti in fila
  Scrivi un programma che dato:
    a) Un numero totale di gatti
    b) Il numero dei gatti presenti in ogni fila
  Restituisca in output:
    - Il numero di file risultanti
    - Nel caso l'ultima fila risulti incompleta indicare il numero di gatti mancanti per completarla (quanti gatti mancano per arrivare a b?)

  Esempio:
    Input: numero di gatti = 44, gatti per fila = 6
    Output: numero di file = 8, gatti mancanti = 4

  Consigli:
  Per l'arrotondamento ti consiglio di non usare Math.round (arrotonda all'intero superiore solo da .5 in su),
  utilizza Math.ceil (arrotonda sempre all'intero superiore).

  http://www.imparareaprogrammare.it
*/
namespace esercizidiprogrammazione_csharp_gattiinfila;

public class Gattiinfila
{
    int totaleGatti, gattiPerFila;
    int totaleFile, gattiMancanti;
    public void soluzioneGattiInFila()
    {
        letturaInput();
        calcolaRisultato();
        stampaRisultato();
    }

    private void letturaInput()
    {

        Console.WriteLine("Inserire numero totale di gatti : ");
        while(!(int.TryParse(Console.ReadLine(), out totaleGatti))) {
            Console.WriteLine("Riprova. Inserire un numero valido");
        }
        Console.WriteLine("Inserire numero di gatti presenti in ogni fila : ");
        while (!(int.TryParse(Console.ReadLine(), out gattiPerFila)))
        {
            Console.WriteLine("Riprova. Inserire un numero valido");
        }

    }
    
    private void calcolaRisultato()
    {
        totaleFile = (int) Math.Ceiling((double) totaleGatti / (double) gattiPerFila);
        Math.DivRem(totaleGatti,gattiPerFila, out gattiMancanti);
        if (gattiMancanti > 0)
        {
            gattiMancanti = gattiPerFila - gattiMancanti; 
        }

    }

    private void stampaRisultato()
    {
        Console.WriteLine($"numero di file : {totaleFile}");
        Console.WriteLine($"gatti mancanti : {gattiMancanti}");
    }
}