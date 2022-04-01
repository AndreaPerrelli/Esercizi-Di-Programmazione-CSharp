namespace esercizidiprogrammazione_csharp_MainMenu;
using System;
using esercizidiprogrammazione_csharp_sommaemedia;
using esercizidiprogrammazione_csharp_quantianniha;
using esercizidiprogrammazione_csharp_ContaIlTempo;
public class MenuProgramma
{
	private SommaEMedia? SommaEMediaInstance;
	private QuantiAnniHa? quantiAnniHaInstance;
	private ContaIlTempo? contaIlTempoInstance;

	Dictionary<string, string>? listaEsercizi;
	int scelta; bool sceltaNonValida;
	private MenuProgramma menuProgramma;

	public MenuProgramma()
	{
		SommaEMediaInstance = new SommaEMedia();
		quantiAnniHaInstance = new QuantiAnniHa();
		contaIlTempoInstance = new ContaIlTempo();
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
			sceltaNonValida = true;
			stampaMenu();
		}
		return scelta;
	}

	private void processazioneSceltaLista(int scelta)
    {
        switch (scelta)
        {
            case 1:
				if (SommaEMediaInstance != null)
                {
					SommaEMediaInstance.soluzioneSommaEMedia();
				}
				break;
			case 2:
				if (quantiAnniHaInstance != null)
                {
					quantiAnniHaInstance.soluzioneQuantiAnniHa();
				}
				break;
			case 3:
				if (contaIlTempoInstance != null)
				{
					contaIlTempoInstance.soluzioneContaIlTempo();

				}
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

		if(keyPressed == ConsoleKey.Escape)
        {
			return;
        }
		if (keyPressed == ConsoleKey.Enter)
        {
			Console.Clear();
			SommaEMediaInstance = null; quantiAnniHaInstance = null;
			listaEsercizi = null;
			scelta = 0;
			sceltaNonValida = false;
			MenuProgramma menuProgramma = new MenuProgramma();
			menuProgramma.MenuProgrammaScelta();
		}
    }
}
