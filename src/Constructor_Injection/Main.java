package Constructor_Injection;

public class Main {
    public static void main(String[] args)
    {
        SelectWriter selectDocumentWriter = new SelectWriter(new DocumentWriter());
        selectDocumentWriter.displaySelectedWriter();

        SelectWriter selectLetterWriter = new SelectWriter(new LetterWriter());
        selectLetterWriter.displaySelectedWriter();
    }
}
