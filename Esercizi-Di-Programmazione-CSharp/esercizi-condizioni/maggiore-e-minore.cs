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
        // reading input
        ReadInput();
        //checking inputNumbers existence
        if (inputNumbers != null)
        {
            // calculate value of max and min
            maxNumber = CalculateMaxValue(inputNumbers);
            minNumber = CalculateMinValue(inputNumbers);
        }
        // print result
        PrintResult(maxNumber, minNumber);
    }

    private void ReadInput()
    {
        int number;
        inputNumbers = new List<int>();
        for (int i = 0; i < 4; i++)
        {            
            //Reading Input, checking if it is an int otherwise prompt user to retry 
            Console.WriteLine("Inserisci numero");
            while(!(int.TryParse(Console.ReadLine(), out number)))
            {
                Console.WriteLine("Non hai inserito un numero! Riprova");
            }
            // adding input to a List
            inputNumbers.Add(number);
        }

    }

    private int CalculateMaxValue(List<int> inputNumbers)
    {
        // returning Max value of the List
        return inputNumbers.Max();
    }

    private int CalculateMinValue(List<int> inputNumbers)
    {
        // returning Min value of the List
        return inputNumbers.Min();
    }

    private void PrintResult(int max, int min)
    {
        // Printing the result in console
        Console.WriteLine($"Il massimo è {max}, il minimo è {min}");

    }
 

}