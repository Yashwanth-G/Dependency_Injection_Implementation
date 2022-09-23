package Constructor_Injection;

public class LetterWriter implements IWriter{
    @Override
    public void write() {
        System.out.println("Letter Writer Implementation");
    }
}
