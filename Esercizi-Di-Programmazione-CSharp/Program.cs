namespace esercizidiprogrammazione_csharp_MainProgram;
using esercizidiprogrammazione_csharp_MainMenu;
public class MainProgram{

    public MenuProgramma mainMenuInstance;
    public MainProgram()
    {
        mainMenuInstance = new MenuProgramma();
    }
    static void Main()
    {
        MainProgram instance = new MainProgram();
        //instance.SommaEMediaInstance.soluzioneSommaEMedia();
        instance.mainMenuInstance.MenuProgrammaScelta();
    }
}

