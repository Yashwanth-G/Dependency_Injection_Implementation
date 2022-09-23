using System;

public interface IWriter
{
    public void write();
}

public class DocumentWriter : IWriter
{
    public void write()
    {
        Console.WriteLine("Document Writer");
    }
}

public class LetterWriter : IWriter
{
    public void write()
    {
        Console.WriteLine("Letter Writer");
    }
}


public class SelectWriter
{

    private IWriter writer;
    public SelectWriter(IWriter writer)
    {
        this.writer = writer;
    }

    public void DisplayWriter()
    {
        writer.write();
    }
}

public class Constructor_Injection
{
    static void Main(string[] args)
    {

        // Dependency object is passed through the Constructor below.
        SelectWriter sw = new SelectWriter(new LetterWriter());

        sw.DisplayWriter();
    }
}
