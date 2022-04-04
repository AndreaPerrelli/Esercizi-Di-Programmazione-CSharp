/*
  La calcolatrice
  Scrivi un programma che dati:
    - Due numeri
    - Una stringha che identifichi l'operazione da eseguire, es: "somma"
  Restituisca il valore ottenuto calcolando l'operazione tra i due numeri.

  Le operazioni supportate sono le suguenti:
    somma
    sottrazione
    moltiplicazione
    divisione
    modulo (solo tra interi)
    potenza
    media


  Esempi:
    Input: a = 5, b = 6, operazione = "somma"
    Output: 11

    Input: a = 5, b = 6, operazione = "media"
    Output: 5.5


  Utilizza il costrutto Switch-Case, gestire anche il caso di operazione non valida (non presente tra le operazioni consentite).


  http://www.imparareaprogrammare.it
*/
namespace esercizidiprogrammazione_csharp_Calculator;
public partial class Calculator
{
    int n1, n2, result;
    PossibleOperations op;
    public Calculator()
    {
    }

    public void CalculatorSolution()
    {
        // initialize the Solution
        initializeSolution();
        // running methods to calculate the Solution
        calculateSolution();
    }
    private void initializeSolution()
    {
        inizializzaDescrizioneEsercizio();
    }

    private void calculateSolution()
    {
        // read input
        (n1, n2, op) = readInput();
        //picking operation based on the number wrote by the user and assigning the result of the operation
        result = chooseOperation(op);
        // printing the result
        printResult(result);
    }

    private (int, int, PossibleOperations) readInput()
    {
        Console.WriteLine("Enter first number :");
        while (!(int.TryParse(Console.ReadLine(), out n1)))
        {
            Console.WriteLine("Wrong number, retry.");
        }
        Console.WriteLine("Enter second number : ");
        while(!(int.TryParse(Console.ReadLine(), out n2)))
        {
            Console.WriteLine("Wrong number, retry.");
        }
        Console.WriteLine("Enter desired operation. Possible values are : " + Environment.NewLine + 
            "0: Sum, 1: Subtraction, 2: Multiplication, 3: Division, 4: Mod, 5: Power, 6: Average");
        while(!(Enum.TryParse(Console.ReadLine(), out op)))
        {
            Console.WriteLine("Wrong operation. Retry!");
        }
        
        return (n1, n2, op);
    }

    private int chooseOperation(PossibleOperations operations)
    {
        // picking operation with switch case, based on the user decision we call a resolve operation math method
        switch (operations)
        {
            case PossibleOperations.SUM:
                result = makeSum(n1, n2);
                break;
            case PossibleOperations.SUBTRACTION:
                result = makeSubtraction(n1, n2);
                break;
            case PossibleOperations.MULTIPLICATION:
                result = makeMultiplication(n1, n2);
                break;
            case PossibleOperations.DIVISION:
                result = makeDivision(n1, n2);
                break;
            case PossibleOperations.MOD:
                result = makeMod(n1, n2);
                break;
            case PossibleOperations.POWER:
                result = makePower(n1, n2);
                break;
            case PossibleOperations.AVERAGE:
                result = makeAverage(n1, n2);
                break;
            default:
                Console.WriteLine("Wrong operation, retry!");
                calculateSolution();
                break;
        }
        return result;
    }

    private int makeSum(int n1, int n2)
    {
        //returning Sum operation
        return n1 + n2;
    }

    private int makeSubtraction(int n1, int n2)
    {
        //returning Subtraction operation
        return n1 - n2;
    }

    private int makeMultiplication(int n1, int n2)
    {
        //returning Multiplication operation
        return n1 * n2;
    }
    private int makeDivision(int n1, int n2)
    {
        //returning division operation
        return n1 / n2;
    }
    
    private int makeMod(int n1, int n2)
    {
        //returning mod operation
        return n1 % n2;
    }
    private int makePower(int n1, int n2)
    {
        //returning power operation
        for (int i = 0; i < n2; i++)
        {
            n1 *= n1;
        }
        return n1;
    }
    private int makeAverage(int n1, int n2)
    {
        // returning average operation
        return (n1 + n2) / 2;
    }

    private void printResult(int result)
    {
        // printing the result
        Console.WriteLine($"Il risultato dell'operazione è : {result}");
    }

    private void inizializzaDescrizioneEsercizio()
    {
        // printing description of exercise
        Console.Title = "Esercizio numero 1 : Somma e Media";
        Console.Clear();
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine(@"
  La calcolatrice
  Scrivi un programma che dati:
    - Due numeri
    - Una stringha che identifichi l'operazione da eseguire, es: somma
  Restituisca il valore ottenuto calcolando l'operazione tra i due numeri.

  Le operazioni supportate sono le suguenti:
    somma
    sottrazione
    moltiplicazione
    divisione
    modulo(solo tra interi)
    potenza
    media


  Esempi:
    Input: a = 5, b = 6, operazione = somma
    Output: 11

    Input: a = 5, b = 6, operazione = media
    Output: 5.5


  Utilizza il costrutto Switch - Case, gestire anche il caso di operazione non valida(non presente tra le operazioni consentite).


  http://www.imparareaprogrammare.it

  Soluzione scritta da Andrea Antonio Perrelli. © 2022. All rights reserved.

");
        Console.WriteLine(Environment.NewLine);
    }

    //ENUM with the defined operations
    enum PossibleOperations
    {
        SUM,
        SUBTRACTION,
        MULTIPLICATION,
        DIVISION,
        MOD,
        POWER,
        AVERAGE
    }
}