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
   public void SelectWriterType(IWriter writer)
    {
        writer.write();
    }
}

public class Method_Injection
{
    static void Main(string[] args)
    {
        SelectWriter sw = new SelectWriter();
        sw.SelectWriterType(new LetterWriter());
    }
}
