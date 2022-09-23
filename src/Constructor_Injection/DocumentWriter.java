package Constructor_Injection;

public class DocumentWriter implements IWriter{
    @Override
    public void write() {
        System.out.println("Document Writer Implementation");
    }
}
