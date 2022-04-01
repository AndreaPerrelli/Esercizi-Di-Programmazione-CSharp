/*
  Quanti anni ha?
  Scrivi un programma che dato l'anno corrente e un anno di nascita determini:
    - l'età della persona,
    - quanti anni sono necessari per raggiungere i 100
  Restituisca in output entrambi i risultati.

  Esempio:
    Input: anno corrente = 2018, anno di nascita = 1991
    Ouput: età = 27, anni mancanti = 73

  http://www.imparareaprogrammare.it
*/

namespace esercizidiprogrammazione_csharp_quantianniha;
public class QuantiAnniHa
{
    int annoCorrente, annoDiNascita, età, anniMancanti;
    bool annoInseritoNonValido;

    public void soluzioneQuantiAnniHa()
    {
        inizializzaVariabili();
        leggiAnno();
        calcolaEtà(annoCorrente, annoDiNascita);
        calcolaAnniMancanti(età);
        stampa();
    }

    private void inizializzaVariabili()
    {
        annoCorrente = 0; annoDiNascita = 0; età = 0; anniMancanti = 0;
    }

    private void leggiAnno()
    {
        Console.WriteLine("Inserisci anno corrente :");
        while (!int.TryParse(Console.ReadLine(), out annoCorrente))
        {
            annoInseritoNonValido = true;
            stampa();
        }
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("Inserisci anno di nascità :");
        while (!int.TryParse(Console.ReadLine(), out annoDiNascita))
        {
            annoInseritoNonValido = true;
            stampa();
        }
    }
    private int calcolaEtà(int annoCorrente, int annoDiNascita)
    {
        return età = annoCorrente - annoDiNascita;
    }
    private int calcolaAnniMancanti(int età)
    {
        return anniMancanti = -(età - 100);
    }
    private void stampa()
    {
        Console.WriteLine($"L'età della persona è : {età}");
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine($"Sono necessari {anniMancanti} anni per raggiungere i 100");
        Console.WriteLine(Environment.NewLine);
    }
    
}
