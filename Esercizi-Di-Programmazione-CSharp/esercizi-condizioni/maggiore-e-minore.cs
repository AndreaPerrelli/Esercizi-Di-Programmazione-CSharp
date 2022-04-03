/*
  Maggiore e minore
  Scrivi un programma che dati quattro numeri in input,
  restituisca in output il maggiore e il minore.

  Esempio:
    Input: a = 3, b = -1, c = 4, d = -2
    Output: maggiore = 4, minore = -2
    

  http://www.imparareaprogrammare.it
*/

namespace esercizidiprogrammazione_csharp_MaggioreEMinore;
public partial class MaggioreEMinore {
    List<int>? inputNumbers;
    int maxNumber;
    int minNumber;
    public MaggioreEMinore()
    {
    }

    public void MaxMinSolution()
    {
        ReadInput();
        if (inputNumbers != null)
        {
            maxNumber = CalculateMaxValue(inputNumbers);
            minNumber = CalculateMinValue(inputNumbers);
        }
        PrintResult(maxNumber, minNumber);
    }

    private void ReadInput()
    {
        int number;
        inputNumbers = new List<int>();
        for (int i = 0; i < 4; i++)
        {            
            Console.WriteLine("Inserisci numero");
            while(!(int.TryParse(Console.ReadLine(), out number)))
            {
                Console.WriteLine("Non hai inserito un numero! Riprova");
            }
            inputNumbers.Add(number);
        }

    }

    private int CalculateMaxValue(List<int> inputNumbers)
    {
        return inputNumbers.Max();
    }

    private int CalculateMinValue(List<int> inputNumbers)
    {
        return inputNumbers.Min();
    }

    private void PrintResult(int max, int min)
    {
        Console.WriteLine($"Il massimo è {max}, il minimo è {min}");

    }
 

}