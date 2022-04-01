using esercizidiprogrammazione_csharp_sommaemedia;

public class MainProgram{

    private SommaEMedia SommaEMediaInstance;
    public MainProgram()
    {
        SommaEMediaInstance = new SommaEMedia();
    }
    static void Main()
    {
        MainProgram instance = new MainProgram();
        instance.SommaEMediaInstance.soluzioneSommaEMedia();
    }
}

