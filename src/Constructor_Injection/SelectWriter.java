package Constructor_Injection;

public class SelectWriter {

    private  IWriter writer;

    public SelectWriter(IWriter writer){
        this.writer = writer;
    }

    public void displaySelectedWriter(){
        writer.write();
    }
}
