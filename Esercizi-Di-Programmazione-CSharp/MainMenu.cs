namespace esercizidiprogrammazione_csharp_MainMenu;
using esercizidiprogrammazione_csharp_ContaIlTempo;
using esercizidiprogrammazione_csharp_quantianniha;
using esercizidiprogrammazione_csharp_sommaemedia;
using esercizidiprogrammazione_csharp_gattiinfila;
using esercizidiprogrammazione_csharp_pariodispari;
using esercizidiprogrammazione_csharp_MaggioreEMinore;
using esercizidiprogrammazione_csharp_Calculator;
using esercizidiprogrammazione_csharp_CakeMenu;
using esercizidiprogrammazione_csharp_CountDigits;
using esercizidiprogrammazione_csharp_DoTheProfessor;
using esercizidiprogrammazione_csharp_GuessNumber;
using esercizidiprogrammazione_csharp_WhatDayIsToday;
using esercizidiprogrammazione_csharp_ColdOrHot;
using esercizidiprogrammazione_csharp_CountTable;
using esercizidiprogrammazione_csharp_RunToTheDozen;
using System;
public class MenuProgramma
{
    private SommaEMedia? SommaEMediaInstance;
    private QuantiAnniHa? quantiAnniHaInstance;
    private ContaIlTempo? contaIlTempoInstance;
    private Gattiinfila? gattiinfilaInstance;
    private PariODispari? pariODispariInstance;
    private MaggioreEMinore? maggioreEMinoreInstance;
    private Calculator? CalculatorInstance;
    private CakeMenu? CakeMenuInstance;
    private CountDigits? CountDigitsInstance;
    private DoTheProfessor? doTheProfessorInstance;
    private GuessNumber? guessNumberInstance;
    private WhatDayIsToday? whatDayIsTodayInstance;
    private ColdOrHot? coldOrHotInstance;
    private CountTable? countTableInstance;
    private RunToTheDozen? runToTheDozenInstance;
   
    Dictionary<string, string>? listaEsercizi;
    int scelta;

    public MenuProgramma()
    {      
    }

    public void MenuProgrammaScelta()
    {
        inizializzaLista();
        stampaMenu();
        scelta = sceltaLista();
        processazioneSceltaLista(scelta);
        riavvioProgramma();
    }

    private void inizializzaLista()
    {
        listaEsercizi = new Dictionary<string, string>();
        listaEsercizi.Add("1", "Somma e media");
        listaEsercizi.Add("2", "Quanti anni ha");
        listaEsercizi.Add("3", "Conta il tempo");
        listaEsercizi.Add("4", "Gatti in fila");
        listaEsercizi.Add("5", "Pari o dispari");
        listaEsercizi.Add("6", "Maggiore e Minore");
        listaEsercizi.Add("7", "Calcolatrice");
        listaEsercizi.Add("8", "Menu dei dolci");
        listaEsercizi.Add("9", "Conta cifre");
        listaEsercizi.Add("10", "Fai il professore");
        listaEsercizi.Add("11", "Chi la azzecca");
        listaEsercizi.Add("12", "Che giorno oggi");
        listaEsercizi.Add("13", "Caldo o Freddo");
        listaEsercizi.Add("14", "Ti ricordi le tabelline?");
        listaEsercizi.Add("15", "Rincorri la decina");
    }

    private void stampaMenu()
    {
        Console.Title = "Esercizi di Programmazione in C Sharp";
        Console.WriteLine("Scegliere esercizio da mostrare : ");
        if (listaEsercizi != null)
        {
            foreach (var esercizio in listaEsercizi)
            {
                Console.WriteLine($"{esercizio.Key} : {esercizio.Value}");
            }
        }
    }

    private int sceltaLista()
    {
        while (!int.TryParse(Console.ReadLine(), out scelta))
        {
            stampaMenu();
        }
        return scelta;
    }

    private void processazioneSceltaLista(int scelta)
    {
        switch (scelta)
        {
            case 1:
                SommaEMediaInstance = new SommaEMedia();
                if (SommaEMediaInstance != null)
                    SommaEMediaInstance.soluzioneSommaEMedia();
                break;
            case 2:
                quantiAnniHaInstance = new QuantiAnniHa();
                if (quantiAnniHaInstance != null)
                    quantiAnniHaInstance.soluzioneQuantiAnniHa();
                break;
            case 3:
                contaIlTempoInstance = new ContaIlTempo();
                if (contaIlTempoInstance != null)
                    contaIlTempoInstance.soluzioneContaIlTempo();

                break;
            case 4:
                gattiinfilaInstance = new Gattiinfila();
                if (gattiinfilaInstance != null)
                    gattiinfilaInstance.soluzioneGattiInFila();
                break;
            case 5:
                pariODispariInstance = new PariODispari();
                if (pariODispariInstance != null)
                    pariODispariInstance.soluzionePariODispari();
                break;
            case 6:
                maggioreEMinoreInstance = new MaggioreEMinore();
                if (maggioreEMinoreInstance != null)
                    maggioreEMinoreInstance.MaxMinSolution();
                break;
            case 7:
                CalculatorInstance = new Calculator();
                if (CalculatorInstance != null)
                    CalculatorInstance.CalculatorSolution();
                break;
            case 8:
                CakeMenuInstance = new CakeMenu();
                if (CakeMenuInstance != null)
                    CakeMenuInstance.CakeMenuSolution();
                break;
            case 9:
                CountDigitsInstance = new CountDigits();
                if (CountDigitsInstance != null)
                    CountDigitsInstance.CountDigitsSolution();
                break;
            case 10:
                doTheProfessorInstance = new DoTheProfessor();
                if (doTheProfessorInstance != null)
                    doTheProfessorInstance.DoTheProfessorSolution();
                break;
            case 11:
                guessNumberInstance = new GuessNumber();
                if (guessNumberInstance != null)
                    guessNumberInstance.GuessNumberSolution();
                break;
            case 12:
                whatDayIsTodayInstance = new WhatDayIsToday();
                if (whatDayIsTodayInstance != null)
                    whatDayIsTodayInstance.WhatDayIsTodaySolution();
                break;
            case 13:
                coldOrHotInstance = new ColdOrHot();
                if (coldOrHotInstance != null) 
                    coldOrHotInstance.ColdOrHotSolution();
                break;
            case 14:
                countTableInstance = new CountTable();
                if (countTableInstance != null)
                    countTableInstance.CountTableSolution();
                break;
            case 15:
                runToTheDozenInstance = new RunToTheDozen();
                if (runToTheDozenInstance != null) 
                    runToTheDozenInstance.RunToTheDozenSolution();
                break;
            default:
                break;
        }
    }

    private void riavvioProgramma()
    {
        Console.WriteLine("Premi esc per uscire, invio per tornare al menu principale.");
        ConsoleKey keyPressed = Console.ReadKey().Key;
        while (!(keyPressed == ConsoleKey.Enter) && !(keyPressed == ConsoleKey.Escape))
        {
            Console.WriteLine("Errore!");
            Console.WriteLine("Premi esc per uscire, invio per tornare al menu principale.");
            keyPressed = Console.ReadKey().Key;
        }

        if (keyPressed == ConsoleKey.Escape)
        {
            return;
        }
        if (keyPressed == ConsoleKey.Enter)
        {
            Console.Clear();
            SommaEMediaInstance = null; quantiAnniHaInstance = null;
            listaEsercizi = null;
            scelta = 0;
            MenuProgramma menuProgramma = new MenuProgramma();
            menuProgramma.MenuProgrammaScelta();
        }
    }
}
