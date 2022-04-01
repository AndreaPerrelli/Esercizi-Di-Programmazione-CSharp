/*
  Conta il tempo
  Scrivi un programma che dato un numero di secondi, calcoli la quantità di ore, minuti e secondi corrispondenti e
  poi stampi il risultato. L'output avrà solo numeri interi.

  Esempio:
    Input: 12560
    Output: 3 ore, 29 minuti e 20 secondi.

  Consigli:
  In un'ora ci sono 60 minuti, in un minuto 60 secondi. Quindi quanti secondi ci sono in un'ora? ;)

  http://www.imparareaprogrammare.it
*/

namespace esercizidiprogrammazione_csharp_ContaIlTempo;


public class ContaIlTempo{

    float totaleSecondi;
    float ore, minuti, secondi;
    const float secondiInUnMinuto = 60;
    const float minutiInUnOra = 60;
    const float secondiInUnOra = 3600;

    public void soluzioneContaIlTempo () 
    {
        inizializzaVariabili();
        inizializzaDescrizioneEsercizio();
        totaleSecondi = leggiTotaleSecondi();
        (ore, minuti, secondi) = calcoloRisultato();
        visualizzaRisultato();
    }

    private void inizializzaVariabili()
    {
        totaleSecondi = 0;
        ore = 0; minuti = 0; secondi = 0;

    }

    private int leggiTotaleSecondi()
    {
        int result;
        Console.WriteLine("Inserisci numero totale dei secondi : ");
        while(!(int.TryParse(Console.ReadLine(), out result)))
        {
            Console.WriteLine("Input incorretto");
            Console.WriteLine("Inserire numero totale dei secondi : ");
        }

        return result;

    }

    private (float, float, float) calcoloRisultato()
    {
        ore = totaleSecondi / secondiInUnOra;
        minuti = (totaleSecondi % secondiInUnOra) / minutiInUnOra;
        secondi = (totaleSecondi % secondiInUnOra) % secondiInUnMinuto;
        return (ore, minuti, secondi);
    }

    private void visualizzaRisultato()
    {
        int oreRisultato = (int) ore;
        int minutiRisultato = (int) minuti;
        int secondiRisultato = (int) secondi;

        Console.WriteLine($"Output : {oreRisultato} ore, {minutiRisultato} minuti e {secondiRisultato} secondi . ");
    }

    private void inizializzaDescrizioneEsercizio()
    {
        Console.Title = "Esercizio numero 1 : Somma e Media";
        Console.Clear();
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine(@"
  Conta il tempo
  Scrivi un programma che dato un numero di secondi, calcoli la quantità di ore, minuti e secondi corrispondenti e
  poi stampi il risultato. L'output avrà solo numeri interi.

  Esempio:
    Input: 12560
    Output: 3 ore, 29 minuti e 20 secondi.

  Consigli:
  In un'ora ci sono 60 minuti, in un minuto 60 secondi. Quindi quanti secondi ci sono in un'ora? ;)

  http://www.imparareaprogrammare.it

  Soluzione scritta da Andrea Antonio Perrelli. © 2022. All rights reserved.

");
        Console.WriteLine(Environment.NewLine);
    }
}
