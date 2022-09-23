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
    private IWriter _writer;

    public IWriter writer
    {
        set
        {
            _writer = value;
        }
        get
        {
            if (_writer == null)
                throw new Exception("Object not passed to the property");
            else
                return _writer;
        }
    }
}

public class Setter_Injection
{
    static void Main(string[] args)
    {
        SelectWriter sw = new SelectWriter();
        sw.writer = new DocumentWriter();
        sw.writer.write();
    }
}
